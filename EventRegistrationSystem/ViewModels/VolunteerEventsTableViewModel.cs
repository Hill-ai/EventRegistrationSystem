using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.ViewModels
{
    public class VolunteerEventsTableViewModel
    {

        public IEnumerable<Models.VolunteerEvent> Events { get; set; }

        public IEnumerable<string> EventTypes { get; set; }

        public IEnumerable<string> EventNonProfits { get; set; }

        public string CurrentEventTypeFilter { get; set; }

        public string CurrentEventNonProfitFilter { get; set; }
    }


}