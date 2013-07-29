using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITintheDWebsite.Models;

namespace ITintheDWebsite.Controllers
{
    public class MentorController : Controller
    {
        private DBEntities db = new DBEntities();

        //
        // GET: /Mentor/

        public ActionResult Index()
        {
            return View(db.Mentors.ToList());
        }

        //
        // GET: /Mentor/Details/5

        public ActionResult Details(int id = 0)
        {
            Mentor mentor = db.Mentors.Find(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        //
        // GET: /Mentor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mentor/Create

        [HttpPost]
        public ActionResult Create(Mentor mentor)
        {
            if (ModelState.IsValid)
            {
                db.Mentors.Add(mentor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mentor);
        }

        //
        // GET: /Mentor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Mentor mentor = db.Mentors.Find(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        //
        // POST: /Mentor/Edit/5

        [HttpPost]
        public ActionResult Edit(Mentor mentor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mentor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mentor);
        }

        //
        // GET: /Mentor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Mentor mentor = db.Mentors.Find(id);
            if (mentor == null)
            {
                return HttpNotFound();
            }
            return View(mentor);
        }

        //
        // POST: /Mentor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Mentor mentor = db.Mentors.Find(id);
            db.Mentors.Remove(mentor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}