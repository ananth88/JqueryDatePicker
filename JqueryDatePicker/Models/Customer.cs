using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JqueryDatePicker.Models
{
    public class Customer
    {
        [Display(Name = "Join Date")]
        public string JoinDate { get; set; }
    }
}