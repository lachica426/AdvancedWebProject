/* Name: Nadine Castro, Student#: 301105146*/
using NadineC_301105146_A4.Models;
using NadineC_301105146_A4.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public interface IPlayerRepository
    {

        IQueryable<Player> Players { get; }

        void SavePlayer(PlayerClubViewModel player);

        Player GetPlayer(int playerID);

        Player DeletePlayer(int playerID);

        IQueryable<Player> GetTopPlayers();
    }
}
