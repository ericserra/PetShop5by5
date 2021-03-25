using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Schedule
    {
        public DateTime AppointmentData { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        [Key]
        public int AppointmentProtocol { get; set; }
        public string PaymentMethod { get; set; }       
        public virtual Customer Customer { get; set; }      
        public virtual Pet Pet { get; set; }       
        public virtual Employee Employee { get; set; }       
        public virtual Services Services { get; set; }
    }
}