using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Record
    {
        [Required]
        [Display(Name = "ID")]
        public long id { get; set; }

        [Required]
        [Display(Name = "Entry")]
        public string entry { get; set; }

        [Required]
        [Display(Name = "Timestamp")]
        public DateTime entered{ get; set; }
    }
}