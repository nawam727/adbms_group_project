using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using adbms_group_project.Data;
using adbms_group_project.Models;

namespace adbms_group_project.Controllers
{
    public class CampsController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Camps
        public ActionResult Index()
        {
            return View(db.Camps.ToList());
        }

        // GET: Camps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camp camp = db.Camps.Find(id);
            if (camp == null)
            {
                return HttpNotFound();
            }
            return View(camp);
        }

        // GET: Camps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Camps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Time,Date,Organiser,Venue")] Camp camp)
        {
            if (ModelState.IsValid)
            {
                db.Camps.Add(camp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(camp);
        }

        // GET: Camps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camp camp = db.Camps.Find(id);
            if (camp == null)
            {
                return HttpNotFound();
            }
            return View(camp);
        }

        // POST: Camps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Time,Date,Organiser,Venue")] Camp camp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(camp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(camp);
        }

        // GET: Camps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Camp camp = db.Camps.Find(id);
            if (camp == null)
            {
                return HttpNotFound();
            }
            return View(camp);
        }

        // POST: Camps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Camp camp = db.Camps.Find(id);
            db.Camps.Remove(camp);
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
