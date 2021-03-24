using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Services
    {
        [Key, Column (Order = 1)]
        public int ServiceType { get; set; }
        public decimal TotalValue { get; set; }
        public string ServiceDescription { get; set; }
    }
}