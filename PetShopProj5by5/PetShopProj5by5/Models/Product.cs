using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Product
    {
        [Key, Column(Order = 0)]
        public int ProductId { get; set; }
        public  string Type { get; set; }
        public string ProductDescription { get; set; }
        public decimal IndividualValue { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}