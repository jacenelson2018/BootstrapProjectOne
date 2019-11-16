using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BootStrapProjectOne.Models
{
    public class Student
    {
        [Key]
        public int ACC_STUD_ID { get; set; }

        [Required(ErrorMessage = "First name is a required field")]
        [Display(Name = "First name")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Last name is a required field")]
        [Display(Name = "Last name")]
        public string lName { get; set; }

        [Required(ErrorMessage = "Major is a required field")]
        [Display(Name = "Select your major?")] //hardcoded drop down list
        public string Major { get; set; }

        [Display(Name = "Please upload a professional headshot")]
        public Image Picture { get; set; } //default to an image if none is uploaded

        [Required(ErrorMessage = "Company is a required field")]
        [Display(Name = "What company did you intern with?")]
        public string Company { get; set; }

        [Required(ErrorMessage = "Experience is a required field")]
        [Display(Name = "Tell us how you landed this sweet gig")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Internship Year is a required field")]
        [Display(Name = "What year was your internship in?")]
        public int Internship_Year { get; set; }
    }
}