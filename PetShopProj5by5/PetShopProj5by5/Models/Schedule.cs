using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShopProj5by5.Models
{
    public class Schedule
    {
        public DateTime AppointmentData { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int AppointmentProtocol { get; set; }
        public string  PaymentMethod { get; set; }
        public Customer Customer { get; set; }
        public Pet Pet { get; set; }
        public Employee Employee { get; set; }
        public Services Services { get; set; }
        

    }
}