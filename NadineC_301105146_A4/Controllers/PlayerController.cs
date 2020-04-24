/* Name: Nadine Castro, Student#: 301105146*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NadineC_301105146_A4.Models.ViewModels;
using NadineC_301105146_A4.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NadineC_301105146_A4.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerRepository repository;
        private IClubRepository repositoryClub;


        public PlayerController(IPlayerRepository repo, IClubRepository repo2)
        {
            repository = repo;
            repositoryClub = repo2;
        }

        public ViewResult Index()
        {
          
            return View("ManagePlayers", repository.Players);
        }

        [Authorize]
        public ViewResult AddPlayer() 
        {
            PlayerClubViewModel vm = new PlayerClubViewModel();
            vm.Clubs = repositoryClub.GetClubList();
            return View(vm);
        }

        [Authorize]
        public ViewResult Edit(int playerID)
        {
            PlayerClubViewModel vm = new PlayerClubViewModel();
            vm.Players = repository.GetPlayer(playerID);
            vm.Clubs = repositoryClub.GetClubList();
            return View("EditPlayer", vm);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(PlayerClubViewModel player)
        {
            if (ModelState.IsValid)
            {
                repository.SavePlayer(player);
                TempData["messagePlayer"] = $"{player.Players.FirstName} {player.Players.LastName} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                player.Clubs = repositoryClub.GetClubList();
                return View("AddPlayer", player);

            }
        }

        [Authorize]
        public IActionResult Delete(int playerID)
        {
            Player deletedPlayer = repository.DeletePlayer(playerID);
            if (deletedPlayer != null)
            {
                TempData["messagePlayer"] = $"{deletedPlayer.FirstName} {deletedPlayer.LastName} was deleted";
            }
            return RedirectToAction("Index");
        }

        public ViewResult TopPlayers()
        {
            return View(repository.GetTopPlayers());
        }
    }
}
