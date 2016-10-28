using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Winix
    {
        [Required]
        [Display(Name = "ID")]
        public long id { get; set; }

        [Required]
        [Display(Name = "Entry")]
        public string entry { get; set; }

        [Required]
        [Display(Name = "Timestamp")]
        public long entered{ get; set; }
    }
}