using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EventRegistrationSystem.Models
{
    public class CompanyContract
    {
        public CompanyContract()
        {
            ContractToken = Guid.NewGuid();
        }

        public int CompanyContractID { get; set; }

        public int CompanyID { get; set; }

        public Guid ContractToken { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime ContractStartDate { get; set; }

        public DateTime ContractEndDate { get; set; }

        public int ContractCapacity { get; set; }
    }
}