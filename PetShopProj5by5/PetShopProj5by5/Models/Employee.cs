using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Employee
    {
        [Key, Column(Order = 2)]
        public int IdEmployee { get; set; }
        public string Name { get; set; }
    }
}