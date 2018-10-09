using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    public class EventModels
    {
        public string Company { get; set; }
        public string NonProfit { get; set; }
        public DateTime EventTime { get; set; }
        public Boolean RestrictedByCompany { get; set; }
        public Boolean EventLocked { get; set; }
        public Boolean EventHidden { get;set }
        public int EventCapacity { get; set; }

    }

    public class CreateEventViewModel
    {

    }
}