using System;
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
        [Display(Name ="Doctor Full Name")]
        [StringLength(50)]
        public string college { get; set; }
        [Display(Name = "Doctor First Name")]
        [Required(ErrorMessage ="Doctor First Name is Required")]
        [StringLength(50)]
        public string firstName { get; set; }
        [Display(Name = "Doctor Last Name")]
        [Required(ErrorMessage = "Doctor Last Name is Required")]
        [StringLength(50)]
        public string lastName { get; set; }
        [Display(Name = "Doctor Email Name")]
        [Required(ErrorMessage = "Doctor Email is Required")]
        [StringLength(50)]
        public string email { get; set; }
        [Display(Name = "Doctor Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage ="Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone{ get; set; }
        [Display(Name = "How long have you been a doctor for?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:d)",ApplyFormatInEditMode =true)]
        public DateTime doctorSince { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}