using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cf085115_Mis4200.Models
{
    public class Client
    {
        [Key]
        public int patientID { get; set; }
        [Display(Name = "Patient First Name")]
        [Required(ErrorMessage ="Patient first name is required")]
        public string firstName { get; set; }
        [Display(Name = "Patient Last Name")]
        [Required(ErrorMessage = "Patient last name is required")]
        public string lastName { get; set; }
        [Display(Name = "Patient Email")]
        [Required(ErrorMessage = "Patient email is required")]
        public string email { get; set; }
        [Display(Name = "Patient Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Patient Date of Birth")]
        public DateTime dob { get; set; }
        [Display(Name = "How long have you been a patient for?")]
        public DateTime patientSince { get; set; }
        public ICollection<Appointment> Appointment { get; set; }

    }
}