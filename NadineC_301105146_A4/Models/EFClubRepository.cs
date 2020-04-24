/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NadineC_301105146_A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;
        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }


        public Club GetClub(int clubID) //displays club and its players
        {
            return context.Clubs
                .Include("Players")
                .FirstOrDefault(c => c.ClubID == clubID);
        }

        public Club GetClubDefault() //displays default view for ClubDetails
        {
            return context.Clubs
                .Include("Players")
                .Take(1)
                .OrderBy(c => c.ClubID)
                .FirstOrDefault();
        }
        public IQueryable<Club> Clubs => context.Clubs;

        // gets list of clubs to be displayed in combo box in adding a player 
        public List<SelectListItem> GetClubList()
        {
            List<SelectListItem> clubs = context.Clubs
                .OrderBy(c => c.ClubName)
                .Select(c =>
                   new SelectListItem
                   {
                       Value = c.ClubID.ToString(),
                       Text = c.ClubName
                   }).ToList();

            return clubs;
        }

        public bool CheckClubExist(Club club)
        {
            Club dbEntry = context.Clubs
                .FirstOrDefault(c => c.ClubName == club.ClubName && c.ClubID != club.ClubID);
                if (dbEntry != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }
        public void SaveClub(Club club) //will add or update the club
        {
            if (club.ClubID == 0)
            {
                context.Clubs.Add(club);
            }
            else
            {
                Club dbEntry = context.Clubs
                .FirstOrDefault(c => c.ClubID == club.ClubID);
                if (dbEntry != null)
                {
                    dbEntry.ClubName = club.ClubName;
                    dbEntry.ClubNickName = club.ClubNickName;
                    dbEntry.Description = club.Description;
                    dbEntry.YearFounded = club.YearFounded;
                    dbEntry.Coach = club.Coach;
                    dbEntry.President = club.President;
                }
            }
            context.SaveChanges();
        }

        public Club DeleteClub(int clubID) //will delete the club
        {
            Club dbEntry = context.Clubs
            .FirstOrDefault(c => c.ClubID == clubID);
            if (dbEntry != null)
            {
                context.Clubs.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

    }
}
