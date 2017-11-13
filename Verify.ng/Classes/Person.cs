using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Verify.ng.Classes
{
    public class Person
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Surname")]
        public string SurName { get; set; }
        public int Age { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        [Display(Name = "Place Of Birth")]
        public string PlaceOfBirth { get; set; }
        public string Citizenship { get; set; }
        [Display(Name = "Mother Maiden Name")]
        public string MotherMaidenName { get; set; }
        public string Address { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        public string Telephone { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Highest Education")]
        public string HighestEducation { get; set; }
        [Display(Name = "Education Status")]
        public string EducationStatus { get; set; }
        [Display(Name = "Education Completion Date")]
        public DateTime EducationCompletionDate { get; set; }
        [Display(Name = "Education Course Title")]
        public string EducationCourseTitle { get; set; }
        [Display(Name = "Institution Attended")]
        public string InstitutionAttended { get; set; }
    }
}