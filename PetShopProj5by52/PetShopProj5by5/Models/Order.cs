using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Order
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }
        public decimal OrderTotal { get; set; }
        public string PaymentMethod { get; set; }

        //[ForeignKey("Customer"), Column(Order = 0)]
        public virtual Customer Customer { get; set; }

        //[ForeignKey("Product"), Column(Order = 0)]
        public virtual Product Product { get; set; }
    }
}