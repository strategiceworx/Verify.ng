using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Verify.ng.Classes;

namespace Verify.ng.Models
{
    public class PersonModels : Person 
    {
        Person person = new Person();

        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public string SurName { get; set; }
        //public int Age { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string Sex { get; set; }
        //public string PlaceOfBirth { get; set; }
        //public string Citizenship { get; set; }
        //public string MotherMaidenName { get; set; }
        //public string Address { get; set; }
        //public string Height { get; set; }
        //public string Weight { get; set; }
        //public string MaritalStatus { get; set; }
        //public string Telephone { get; set; }
        //public string EmailAddress { get; set; }
        //public string HighestEducation { get; set; }
        //public string EducationStatus { get; set; }
        //public DateTime EducationCompletionDate { get; set; }
        //public string EducationCourseTitle { get; set; }
        //public string InstitutionAttended { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<PersonModels> Person { get; set; }
    }
}