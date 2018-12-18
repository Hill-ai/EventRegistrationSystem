﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    public class FakeEventsRepository : IEventsRepository
    {
        public IEnumerable<EventModel> Events => new List<EventModel>
        {
            new EventModel{ Company = "CSX",
                NonProfit =  "Helping Hand" ,
                EventTime = DateTime.Now,
                RestrictedByCompany = true,
                EventLocked = true,
                EventHidden = true,
                EventCapacity = 50,
                EventID = 1001,
                EventName = "5k Fun Run",
                EventDescription = "Help out by collecting donations for every mile you run",
                EventDate = DateTime.Now,
                EventStartTime = DateTime.Now,
                EventEndTime = DateTime.Now,
                EventDetails = "located at such and such location",
                EventInterest = 15,
                EventFiles = "some files and stuff",
                EventTotalTime = "3 hours",
                NonProfitID = 2100 },

            new EventModel{ Company = "Black Knight",
                NonProfit =  "Yogas 4 Change" ,
                EventTime = DateTime.Now,
                RestrictedByCompany = true,
                EventLocked = true,
                EventHidden = true,
                EventCapacity = 50,
                EventID = 1002,
                EventName = "Yoga Lessons",
                EventDescription = "Help out by teaching yoga",
                EventDate = DateTime.Now,
                EventStartTime = DateTime.Now,
                EventEndTime = DateTime.Now,
                EventDetails = "located at such and such location",
                EventInterest = 15,
                EventFiles = "some files and stuff",
                EventTotalTime = "3 hours",
                NonProfitID = 2101 }
        };
    }
}