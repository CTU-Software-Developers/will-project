using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace event_management_system.Models
{
    public class CodeStorage
    {
        [Required]
        [Key]
        [Display(Name = "Unique code")]
        public string Code { get; set; }

        [Required]
        [Display(Name = "Code type")]
        public string CodeType { get; set; }

        [Display(Name = "Claimed by")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Used")]
        public Boolean IsUsed { get; set; }
    }
}