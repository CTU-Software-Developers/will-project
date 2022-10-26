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
    public class CodeStoragesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CodeStorages
        public ActionResult CodesTable()
        {
            return View(db.CodeStorages.ToList());
        }

        // GET: CodeStorages/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStorage codeStorage = db.CodeStorages.Find(id);
            if (codeStorage == null)
            {
                return HttpNotFound();
            }
            return View(codeStorage);
        }

        // GET: CodeStorages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CodeStorages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,CodeType,Username")] CodeStorage codeStorage)
        {
            if (ModelState.IsValid)
            {
                db.CodeStorages.Add(codeStorage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codeStorage);
        }

        // GET: CodeStorages/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStorage codeStorage = db.CodeStorages.Find(id);
            if (codeStorage == null)
            {
                return HttpNotFound();
            }
            return View(codeStorage);
        }

        // POST: CodeStorages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,CodeType,Username")] CodeStorage codeStorage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codeStorage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codeStorage);
        }

        // GET: CodeStorages/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeStorage codeStorage = db.CodeStorages.Find(id);
            if (codeStorage == null)
            {
                return HttpNotFound();
            }
            return View(codeStorage);
        }

        // POST: CodeStorages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CodeStorage codeStorage = db.CodeStorages.Find(id);
            db.CodeStorages.Remove(codeStorage);
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
