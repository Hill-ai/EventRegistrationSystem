using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    public class VolunteerEvent
    {
        public string Company { get; set; }
        public string NonProfit { get; set; }
        //public DateTime EventTime { get; set; }
        public Boolean RestrictedByCompany { get; set; }
        public Boolean EventLocked { get; set; }
        public Boolean EventHidden { get; set; }
        public int EventCapacity { get; set; }

        public int VolunteerEventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventEndTime { get; set; }
        public string EventDetails { get; set; }
        public int EventInterest { get; set; }
        public string EventFiles { get; set; }
        public int EventTotalTime { get; set; }
        public int NonProfitID { get; set; }


        public VolunteerEvent() {
        }



    }

    public class CreateEventViewModel
    {

    }
    
}