using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootStrapProjectOne.Models
{
    public class Student
    {
        [Key]
        public int? StudID { get; set; }
    }
}