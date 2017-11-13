﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Verify.ng.Models;

namespace Verify.ng.Controllers
{
    public class PersonController : Controller
    {
        private PersonContext db = new PersonContext();

        // GET: Person
        public ActionResult Index()
        {
            return View(db.Person.ToList());
        }

        // GET: Person/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModels personModels = db.Person.Find(id);
            if (personModels == null)
            {
                return HttpNotFound();
            }
            return View(personModels);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,MiddleName,SurName,Age,DateOfBirth,Sex,PlaceOfBirth,Citizenship,MotherMaidenName,Address,Height,Weight,MaritalStatus,Telephone,EmailAddress,HighestEducation,EducationStatus,EducationCompletionDate,EducationCourseTitle,InstitutionAttended")] PersonModels personModels)
        {
            if (ModelState.IsValid)
            {
                db.Person.Add(personModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personModels);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModels personModels = db.Person.Find(id);
            if (personModels == null)
            {
                return HttpNotFound();
            }
            return View(personModels);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,MiddleName,SurName,Age,DateOfBirth,Sex,PlaceOfBirth,Citizenship,MotherMaidenName,Address,Height,Weight,MaritalStatus,Telephone,EmailAddress,HighestEducation,EducationStatus,EducationCompletionDate,EducationCourseTitle,InstitutionAttended")] PersonModels personModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personModels);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonModels personModels = db.Person.Find(id);
            if (personModels == null)
            {
                return HttpNotFound();
            }
            return View(personModels);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonModels personModels = db.Person.Find(id);
            db.Person.Remove(personModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
