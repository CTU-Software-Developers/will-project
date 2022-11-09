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
    public class EventStoragesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EventStorages
        public ActionResult EventsTable()
        {
            return View(db.EventStorages.ToList());
        }

        // GET: EventStorages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventStorage eventStorage = db.EventStorages.Find(id);
            if (eventStorage == null)
            {
                return HttpNotFound();
            }
            return View(eventStorage);
        }

        // GET: EventStorages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventStorages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,EventType,EventName,EventDate,EventDescription,EventTime")] EventStorage eventStorage)
        {
            if (ModelState.IsValid)
            {
                db.EventStorages.Add(eventStorage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventStorage);
        }

        // GET: EventStorages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventStorage eventStorage = db.EventStorages.Find(id);
            if (eventStorage == null)
            {
                return HttpNotFound();
            }
            return View(eventStorage);
        }

        // POST: EventStorages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,EventType,EventName,EventDate,EventDescription,EventTime")] EventStorage eventStorage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventStorage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventStorage);
        }

        // GET: EventStorages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventStorage eventStorage = db.EventStorages.Find(id);
            if (eventStorage == null)
            {
                return HttpNotFound();
            }
            return View(eventStorage);
        }

        // POST: EventStorages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventStorage eventStorage = db.EventStorages.Find(id);
            db.EventStorages.Remove(eventStorage);
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

        // GET: EventStorages
        public ActionResult SportsView()
        {
            return View(db.EventStorages.ToList());
        }

        // GET: EventStorages
        public ActionResult RacingView()
        {
            return View(db.EventStorages.ToList());
        }

        // GET: EventStorages
        public ActionResult RageView()
        {
            return View(db.EventStorages.ToList());
        }
    }
}
