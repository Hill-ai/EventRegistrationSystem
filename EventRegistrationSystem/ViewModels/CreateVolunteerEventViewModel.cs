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
        public   SelectList NPro { get; set; }
        public   SelectList Com { get; set; }
        public int IdTag { get; set; }
        public int IdNPro { get; set; }
        public int IdCom { get; set; }
            
            public CreateVolunteerEventViewModel (VolunteerEvent volunteerEvent,List<Tag>tag, List<NonProfit>npro, List<Company>com)
        {
            this.VolunteerEvent = volunteerEvent;
            this.Tag = new SelectList(tag, "TagId", "TagDescription");
            this.NPro = new SelectList(npro, "NonProfitId", "Name");
            this.Com = new SelectList(com, "CompanyId", "Name");
        }
        public CreateVolunteerEventViewModel() { }

    }
}