/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.AspNetCore.Mvc.Rendering;
using NadineC_301105146_A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public interface IClubRepository
    {
        IQueryable<Club> Clubs { get; }

        Club GetClub(int clubID);

        Club GetClubDefault();

        void SaveClub(Club club);

        Club DeleteClub(int clubID);
        List<SelectListItem> GetClubList();
        bool CheckClubExist(Club club);
    }
}
