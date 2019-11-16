using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootStrapProjectOne.Models
{
    public class Question
    {
        [Key]
        public int Q_ID { get; set; }

        [Required]
        [Display(Name ="Question")]
        [StringLength(200)]
        public string Ques { get; set; }

        public int A_ID { get; set; }
    }
}