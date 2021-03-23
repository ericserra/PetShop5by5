using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}