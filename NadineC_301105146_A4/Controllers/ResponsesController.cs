using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NadineC_301105146_A4.Models;

namespace NadineC_301105146_A4.Controllers
{
    public class ResponsesController : Controller
    {
        private IResponseRepository repository;
        private IEventRepository repositoryEvent;

        public ResponsesController(IResponseRepository repo, IEventRepository repo2)
        {
            repository = repo;
            repositoryEvent = repo2;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Event");
        }

        [HttpGet]
        public ViewResult RsvpForm(int eventID)
        {
            Response response = new Response();
            response.Events = repositoryEvent.GetEvent(eventID);
            return View(response);
        }

        [HttpPost]
        public ViewResult RsvpForm(Response response)
        {

            response.Events = repositoryEvent.GetEvent(response.EventID);
            if (ModelState.IsValid)
            {
                if (!repository.IsRegistered(response)) { 
                    repository.AddResponse(response);
                    return View("Registered",response);
                    
                }else{
                    TempData["message"] = $"{response.Email} is already registered to this event.";
                    return View(response);
                }
            }else{

                return View(response);
            }
        }
    }
}