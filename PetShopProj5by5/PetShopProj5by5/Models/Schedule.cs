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
        public DateTime AppointmentTime { get; set; }
        [Key]
        public int AppointmentProtocol { get; set; }
        public string PaymentMethod { get; set; }
        [ForeignKey("Customer"), Column(Order = 0)]
        public virtual Customer Customer { get; set; }
        [ForeignKey("Pet"), Column(Order = 0)]
        public virtual Pet Pet { get; set; }
        [ForeignKey("Employee"), Column(Order = 0)]
        public virtual Employee Employee { get; set; }
        [ForeignKey("Services"), Column(Order = 0)]
        public virtual Services Services { get; set; }


    }
}