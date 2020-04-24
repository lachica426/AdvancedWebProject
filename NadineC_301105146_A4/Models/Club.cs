/* Name: Nadine Castro, Student#: 301105146*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class Club
    {
        public int ClubID { get; set; }

        [Required(ErrorMessage = "Please enter a club name")]
        public string ClubName { get; set; }

        [Required(ErrorMessage = "Please enter a club nickname")]
        public string ClubNickName { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter year founded")]
        public int YearFounded { get; set; }

        [Required(ErrorMessage = "Please enter a coach")]
        public string Coach { get; set; }

        [Required(ErrorMessage = "Please enter a president")]
        public string President { get; set; }
        public List<Player> Players { get; set; } //will contain list of players to be displayed in the Club Details
    }
}
