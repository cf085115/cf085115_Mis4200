using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cf085115_Mis4200.Models
{
    public class Appointment
    {
        public int appointmentId { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        public ICollection<Patient>Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}