using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required(ErrorMessage = "Please enter an event name")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter an event date")]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Please enter a venue")]
        public string Venue { get; set; }
        public List<Response> Responses { get; set; }
    }
}
