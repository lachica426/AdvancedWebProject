/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.EntityFrameworkCore;
using NadineC_301105146_A4.Models;
using NadineC_301105146_A4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class EFPlayerRepository : IPlayerRepository
    {

        private ApplicationDbContext context;
        public EFPlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

      
        // lists of players and to display club name
        public IQueryable<Player> Players =>
            context.Players.Include("Clubs").AsQueryable<Player>();

        public void SavePlayer(PlayerClubViewModel player)
        {
            if (player.Players.PlayerID == 0)
            {
                context.Players.Add(player.Players);
            }
            else
            {
                Player dbEntry = context.Players
                .FirstOrDefault(p => p.PlayerID == player.Players.PlayerID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = player.Players.FirstName;
                    dbEntry.LastName = player.Players.LastName;
                    dbEntry.Position = player.Players.Position;
                    dbEntry.ClubID = player.Players.ClubID;
                    dbEntry.Goals = player.Players.Goals;

                }
            }
            context.SaveChanges();
        }

        public Player GetPlayer(int playerID) 
        {
            return context.Players
                .FirstOrDefault(p => p.PlayerID == playerID);
        }

        public Player DeletePlayer(int playerID) //will delete the player
        {
            Player dbEntry = context.Players
            .FirstOrDefault(p => p.PlayerID == playerID);
            if (dbEntry != null)
            {
                context.Players.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public IQueryable<Player> GetTopPlayers()
        {
            return Players.OrderByDescending(p => p.Goals);
        }
    }
}
