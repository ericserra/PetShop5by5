using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal OrderTotal { get; set; }
        public string PaymentMethod { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}