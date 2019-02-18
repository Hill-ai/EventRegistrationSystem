using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventRegistrationSystem.Models;
using EventRegistrationSystem.ViewModels;


namespace EventRegistrationSystem.ViewModels
{
    public class CompanyIndexViewModel
    {
        public IEnumerable<Company>  Companies { get; set; }
        public Company Company { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}