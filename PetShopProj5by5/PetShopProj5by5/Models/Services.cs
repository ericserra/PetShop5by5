using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Services
    {
        [Key]
        public int ServiceType { get; set; }
        public decimal TotalValue { get; set; }
        public string ServiceDescription { get; set; }
    }
}