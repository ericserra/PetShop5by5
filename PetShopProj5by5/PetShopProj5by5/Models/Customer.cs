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

        public virtual ICollection<Address> Address { get; set; }
    }
}