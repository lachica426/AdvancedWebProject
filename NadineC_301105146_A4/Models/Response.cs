using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class Response
    {
        public int ResponseID { get; set; }

        [Required(ErrorMessage = "Please enter your complete name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        public int EventID { get; set; }

        public Event Events { get; set; }
    }
}
