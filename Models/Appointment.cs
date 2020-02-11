using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cf085115_Mis4200.Models
{
    public class Appointment
    {
        [Key]
        public int appointmentId { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int patientID { get; set; }
        public virtual Client Client { get; set; }
    }
}