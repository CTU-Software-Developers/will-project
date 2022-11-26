using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using event_management_system.Models;
using System.Data.SqlClient;
using System.Collections;
using System.Windows;
using static event_management_system.Models.EventStorage;

namespace event_management_system.Controllers
{
    public class EventStoragesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        string connectionString = "Data Source=.;Initial Catalog=willdatabase;Integrated Security=True";
        string sql;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        List<SportList> sports = new List<SportList>();
        List<RaceList> races = new List<RaceList>();
        List<RageList> rage = new List<RageList>();

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
        public ActionResult Create([Bind(Include = "EventID,EventType,EventName,EventDate,EventDescription,EventTime,TicketPrice")] EventStorage eventStorage)
        {
            if (ModelState.IsValid)
            {
                db.EventStorages.Add(eventStorage);
                db.SaveChanges();
                return RedirectToAction("EventsTable");
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
        public ActionResult Edit([Bind(Include = "EventID,EventType,EventName,EventDate,EventDescription,EventTime,TicketPrice")] EventStorage eventStorage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventStorage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("EventsTable");
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
            return RedirectToAction("EventsTable");
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
            con = new SqlConnection(connectionString);
            sql = "SELECT TOP (1000) [EventID], [EventType], [EventName], [EventDate], [EventDescription], [EventTime], [TicketPrice] FROM [willdatabase].[dbo].[EventStorages] where [EventType] != 4 or [EventType] != 6;";

            if (sports.Count > 0)
            {
                sports.Clear();
            }
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sports.Add(new SportList 
                    {
                        EventID = Convert.ToInt32(reader["EventID"])
                        , EventType = Convert.ToInt32(reader["EventType"])
                        , EventName = reader["EventName"].ToString()
                        , EventDate = (Convert.ToDateTime(reader["EventDate"])).ToString("dd-MM-yyyy")
                        , EventDescription = reader["EventDescription"].ToString()
                        , EventTime = (Convert.ToDateTime(reader["EventTime"])).ToString("hh:mm tt")
                        , TicketPrice = Convert.ToDouble(reader["TicketPrice"])
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(ex.ToString());
            }

            return View(sports);
        }

        // GET: EventStorages
        public ActionResult RacingView()
        {
            con = new SqlConnection(connectionString);
            sql = "SELECT TOP (1000) [EventID], [EventType], [EventName], [EventDate], [EventDescription], [EventTime], [TicketPrice] FROM [willdatabase].[dbo].[EventStorages] where [EventType] = 4;";
            if (races.Count > 0)
            {
                races.Clear();
            }
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    races.Add(new RaceList
                    {
                        EventID = Convert.ToInt32(reader["EventID"])
                        ,
                        EventType = Convert.ToInt32(reader["EventType"])
                        ,
                        EventName = reader["EventName"].ToString()
                        ,
                        EventDate = (Convert.ToDateTime(reader["EventDate"])).ToString("dd-MM-yyyy")
                        ,
                        EventDescription = reader["EventDescription"].ToString()
                        ,
                        EventTime = (Convert.ToDateTime(reader["EventTime"])).ToString("hh:mm tt")
                        ,
                        TicketPrice = Convert.ToDouble(reader["TicketPrice"])
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return View(races);
        }

        // GET: EventStorages
        public ActionResult RageView()
        {
            con = new SqlConnection(connectionString);
            sql = "SELECT TOP (1000) [EventID], [EventType], [EventName], [EventDate], [EventDescription], [EventTime], [TicketPrice] FROM [willdatabase].[dbo].[EventStorages] where [EventType] = 6;";
            if (rage.Count > 0)
            {
                rage.Clear();
            }
            try
            {
                con.Open();
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rage.Add(new RageList
                    {
                        EventID = Convert.ToInt32(reader["EventID"])
                        ,
                        EventType = Convert.ToInt32(reader["EventType"])
                        ,
                        EventName = reader["EventName"].ToString()
                        ,
                        EventDate = (Convert.ToDateTime(reader["EventDate"])).ToString("dd-MM-yyyy")
                        ,
                        EventDescription = reader["EventDescription"].ToString()
                        ,
                        EventTime = (Convert.ToDateTime(reader["EventTime"])).ToString("hh:mm tt")
                        ,
                        TicketPrice = Convert.ToDouble(reader["TicketPrice"])
                    });
                }

                con.Close();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            return View(rage);
        }
    }
}
