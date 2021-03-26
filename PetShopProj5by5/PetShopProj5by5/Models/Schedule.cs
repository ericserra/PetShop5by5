using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PetShopProj5by5.Models
{
    public class Schedule
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime AppointmentData { get; set; }
         
        public TimeSpan AppointmentTime { get; set; }
        [Key]
        public int AppointmentProtocol { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [ForeignKey("Pet")]
        public int PetID { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        [ForeignKey("Services")]
        public int ServicesID { get; set; }
        public decimal TotalValue { get; set; }
        public virtual Customer Customer { get; set; }      
        public virtual Pet Pet { get; set; }       
        public virtual Employee Employee { get; set; }       
        public virtual Services Services { get; set; }
    }
}