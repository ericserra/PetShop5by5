using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        //public Customer Customer { get; set; }
    }
}