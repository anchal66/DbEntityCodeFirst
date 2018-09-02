using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DbDemo.Models
{
    public class Emplyee
    {
        [Required(ErrorMessage ="ENter Inputs")]
        public int EmplyeeId { get; set; }
        public string EmpName { get; set; }
    }
}