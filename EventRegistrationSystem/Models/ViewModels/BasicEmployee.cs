//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//
//namespace EventRegistrationSystem.Models.ViewModels
//{
//    [Table("vBasicEmployees")]
//    public class BasicEmployee
//    {
//        [Key]
//        public string UserId { get; set; }
//        
//        public string Email { get; set; }
//        
//        public string FirstName { get; set; }
//        
//        public string LastName { get; set; }
//        
//        public int CompanyId { get; set; }
//        
//        public string CompanyName { get; set; }
//        
//        public bool IsActive { get; set; }
//
//        [NotMapped]
//        public string IsActiveString
//        {
//            get { return IsActive ? "Yes" : "No"; }
//        }
//    }
//}