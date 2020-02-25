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
        [Display(Name = "Appointment Description")]
        public string description { get; set; }
        [Display(Name = "Appointment Date")]
        public DateTime appointmentDate { get; set; }
        [Display(Name = "Doctor ID")]
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }

        public int patientID { get; set; }
        public virtual Client Client { get; set; }
    }
}