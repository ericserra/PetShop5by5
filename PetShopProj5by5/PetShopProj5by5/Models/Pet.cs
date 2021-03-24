using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Pet
    {
        [Key, Column(Order = 0)]
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        [ForeignKey("Customer"), Column(Order = 0)]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}