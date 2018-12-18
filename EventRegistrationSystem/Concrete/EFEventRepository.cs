using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.Abstract;

namespace EventRegistrationSystem.Concrete
{
    public class EFEventRepository : IEventRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Event> Events
        {
            get { return context.Events; }
        }
    }


}