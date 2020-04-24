/* Name: Nadine Castro, Student#: 301105146*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class Player
    {
        public int PlayerID { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter goals")]
        public int Goals { get; set; }
        public int ClubID { get; set; } //holds the Club ID foreign key
        public Club Clubs { get; set; } // allows access to the Club props such as Club name to be displayed in Manage Players
      
    }
}
