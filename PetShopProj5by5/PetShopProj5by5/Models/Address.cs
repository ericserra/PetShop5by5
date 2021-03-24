using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Address
    {
        [Key]
        public int  AddressID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        
        public string  Cep { get; set; }
       [ForeignKey("Customer"), Column(Order = 0)]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}