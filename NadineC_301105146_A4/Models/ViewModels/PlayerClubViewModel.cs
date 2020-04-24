/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.AspNetCore.Mvc.Rendering;
using NadineC_301105146_A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models.ViewModels
{
    public class PlayerClubViewModel
    {
        public Player Players { get; set; }
        public List<SelectListItem> Clubs { get; set; }
    }
}
