using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EventRegistrationSystem.Models
{
    public class Tag
    {

        [Key, Column(Order = 0)]
        public int TagId { get; set; }

        [Column(Order = 1)]
        public string TagDescription { get; set; }
    }
}