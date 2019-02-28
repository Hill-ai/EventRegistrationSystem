using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EventRegistrationSystem.Models;
using System.Web.Mvc;

namespace EventRegistrationSystem.ViewModels
{
    public class CreateVolunteerEventViewModel
    {
        public VolunteerEvent VolunteerEvent { get; set; }
        public   SelectList Tag { get; set; }
        public int IdTag { get; set; }
            
            public CreateVolunteerEventViewModel (VolunteerEvent volunteerEvent,List<Tag>tag)
        {
            this.VolunteerEvent = volunteerEvent;
            this.Tag = new SelectList(tag, "TagId", "TagDescription");
        }
        public CreateVolunteerEventViewModel() { }

    }
}