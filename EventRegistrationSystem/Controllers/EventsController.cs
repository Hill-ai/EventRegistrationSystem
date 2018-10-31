using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Controllers
{
    public class EventsController : Controller
    {
        public IEventsRepository repository;
        public EventsController(IEventsRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Events);
    }
}