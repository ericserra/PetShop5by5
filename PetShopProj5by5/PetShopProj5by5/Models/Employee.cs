using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        public string Name { get; set; }
    }
}