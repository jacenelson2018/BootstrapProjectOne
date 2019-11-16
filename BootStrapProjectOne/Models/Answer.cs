using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootStrapProjectOne.Models
{
    public class Answer
    {
        [Key]
        public int A_ID { get; set; }

        [Required]
        [Display(Name = "Answer")]
        [StringLength(400)]
        public string Answ { get; set; }

        public int Q_ID { get; set; }
    }
}