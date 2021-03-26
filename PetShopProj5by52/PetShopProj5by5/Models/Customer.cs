using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Customer
    {
        [Key, Column(Order = 0)]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

       // public virtual Schedule Schedule { get; set; }
       // public virtual Pet Pet { get; set; }
       // public virtual Order Order { get; set; }
    }
}