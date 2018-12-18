using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Abstract;


namespace EventRegistrationSystem.Controllers
{

    public class EventController : Controller
    {
        private IEventRepository repository;
        public EventController(IEventRepository eventRepository)
        {
            this.repository = eventRepository;
        }

        public ViewResult ListEvents()
        {
            return View(repository.Events);
        }
    }
       
    
}