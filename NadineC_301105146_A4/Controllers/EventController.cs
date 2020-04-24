using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NadineC_301105146_A4.Models;

namespace NadineC_301105146_A4.Controllers
{
    public class EventController : Controller
    {
        private IEventRepository repository;

        public EventController(IEventRepository repo)
        {
            repository = repo;
        }


        public ViewResult Index()
        {
            return View(repository.Events);
        }

        [Authorize]
        public ViewResult AddEvent()
        {
            return View();
        }


        public ViewResult EventDetails(int eventID)
        {

            return View("EventDetails", repository.GetEvent(eventID));
        }

        [Authorize]
        public ViewResult Edit(int eventID) =>
            View("EditEvent", repository.Events
            .FirstOrDefault(e => e.EventID == eventID));

        [HttpPost]
        [Authorize]
        public IActionResult Edit(Event events)
        {
            if (ModelState.IsValid)
            {
                    repository.SaveEvent(events);
                    TempData["message"] = $"{events.EventName} has been saved";
                    return RedirectToAction("Index");
            }
            return View("EditEvent", events);
        }

        [Authorize]
        public ViewResult Create() => View("AddEvent", new Event());


        [Authorize]
        public IActionResult Delete(int eventID)
        {
            Event deletedEvent = repository.DeleteEvent(eventID);
            if (deletedEvent != null)
            {
                TempData["message"] = $"{deletedEvent.EventName} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}