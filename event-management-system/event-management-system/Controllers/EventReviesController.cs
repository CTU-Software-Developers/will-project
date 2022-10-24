using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using event_management_system.Models;

namespace event_management_system.Controllers
{
    public class EventReviesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EventRevies
        public ActionResult Index()
        {
            var eventRevies = db.EventRevies.Include(e => e.EventStorage);
            return View(eventRevies.ToList());
        }

        // GET: EventRevies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRevies eventRevies = db.EventRevies.Find(id);
            if (eventRevies == null)
            {
                return HttpNotFound();
            }
            return View(eventRevies);
        }

        // GET: EventRevies/Create
        public ActionResult Create()
        {
            ViewBag.EventID = new SelectList(db.EventStorages, "EventID", "EventType");
            return View();
        }

        // POST: EventRevies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReviewID,EventID,Username,Review,ReviewDate")] EventRevies eventRevies)
        {
            if (ModelState.IsValid)
            {
                db.EventRevies.Add(eventRevies);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventID = new SelectList(db.EventStorages, "EventID", "EventType", eventRevies.EventID);
            return View(eventRevies);
        }

        // GET: EventRevies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRevies eventRevies = db.EventRevies.Find(id);
            if (eventRevies == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventID = new SelectList(db.EventStorages, "EventID", "EventType", eventRevies.EventID);
            return View(eventRevies);
        }

        // POST: EventRevies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReviewID,EventID,Username,Review,ReviewDate")] EventRevies eventRevies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventRevies).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventID = new SelectList(db.EventStorages, "EventID", "EventType", eventRevies.EventID);
            return View(eventRevies);
        }

        // GET: EventRevies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventRevies eventRevies = db.EventRevies.Find(id);
            if (eventRevies == null)
            {
                return HttpNotFound();
            }
            return View(eventRevies);
        }

        // POST: EventRevies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventRevies eventRevies = db.EventRevies.Find(id);
            db.EventRevies.Remove(eventRevies);
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
