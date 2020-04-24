/* Name: Nadine Castro, Student#: 301105146*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NadineC_301105146_A4.Models;
using NadineC_301105146_A4.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NadineC_301105146_A4.Controllers
{
    public class ClubController : Controller
    {
        private IClubRepository repository;
       
        public ClubController(IClubRepository repo)
        {
            repository = repo;
        }
      
        public ViewResult Index()
        {
            return View(repository.Clubs);
        }

        [Authorize]
        public ViewResult AddClub()
        {
            return View();
        }


        public ViewResult ClubDetails(int clubID)
        {
         
            return View("ClubDetails", repository.GetClub(clubID));
        }

        public ViewResult ClubDetailsDefault(int clubID) //method for Default view of ClubDetails page
        {

            return View("ClubDetails", repository.GetClubDefault());
        }

        [Authorize]
        public ViewResult Edit(int clubID) =>
            View("EditClub", repository.Clubs
            .FirstOrDefault(c => c.ClubID == clubID));

        [HttpPost]
        [Authorize]
        public IActionResult Edit(Club club)
        {

            if (ModelState.IsValid)
            {
                if (!repository.CheckClubExist(club)) { 
                    repository.SaveClub(club);
                    TempData["message"] = $"{club.ClubName} has been saved";
                    return RedirectToAction("Index");
                }else{
                    TempData["message"] = $"{club.ClubName} already exists. Please choose another club name.";
                }

            }
                return View("EditClub", club);
        }

        [Authorize]
        public ViewResult Create() => View("AddClub", new Club());

        //[HttpPost]
        //[Authorize]  //remove later
        //public IActionResult Delete(int clubID)
        //{
        //    Club deletedClub = repository.DeleteClub(clubID);
        //    if (deletedClub != null)
        //    {
        //        TempData["message"] = $"{deletedClub.ClubName} was deleted";
        //    }
        //    return RedirectToAction("Index");
        //}

        [Authorize]  
        public IActionResult Delete(int clubID)
        {
            Club deletedClub = repository.DeleteClub(clubID);
            if (deletedClub != null)
            {
                TempData["message"] = $"{deletedClub.ClubName} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
