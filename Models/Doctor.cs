﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cf085115_Mis4200.Models
{
    public class Doctor
    {
        [Key]
        public int doctorID { get; set; }

        public string college { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone{ get; set; }
        public DateTime doctorSince { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}