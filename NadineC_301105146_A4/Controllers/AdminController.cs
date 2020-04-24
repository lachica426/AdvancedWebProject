/* Name: Nadine Castro, Student#: 301105146*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NadineC_301105146_A4.Models;

namespace NadineC_301105146_A4.Controllers
{
    public class AdminController : Controller
    {
        private IClubRepository repository;
        public AdminController(IClubRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Clubs);
    }
}