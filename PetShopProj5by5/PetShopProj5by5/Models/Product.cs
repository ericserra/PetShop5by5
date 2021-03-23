using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public  string Type { get; set; }
        public string ProductDescription { get; set; }
        public decimal IndividualValue { get; set; }
    }
}