using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace event_management_system.Controllers
{
    public class HomeController : Controller
    {
        willdatabaseContext _context = new willdatabaseContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminPage()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult SportsReviews()
        {
            return View();
        }
        public ActionResult MotorSportsReviews()
        {
            return View();
        }
        public ActionResult RageExpoReviews()
        {
            return View();
        }
        public ActionResult Rage()
        {
            return View();
        }
        public ActionResult Softball()
        {
            return View();
        }
        public ActionResult Baseball()
        {
            return View();
        }
        public ActionResult Cricket()
        {
            return View();
        }
        public ActionResult Hockey()
        {
            return View();
        }
        public ActionResult Netball()
        {
            return View();
        }
        public ActionResult Rugby()
        {
            return View();
        }
        public ActionResult Tennis()
        {
            return View();
        }
        public ActionResult Basketball()
        {
            return View();
        }
        public ActionResult Soccer()
        {
            return View();
        }
        public ActionResult Prize()
        {
            return View();
        }
        public ActionResult Costume()
        {
            return View();
        }
        public ActionResult Tech()
        {
            return View();
        }
        public ActionResult Games()
        {
            return View();
        }
        public ActionResult Lan()
        {
            return View();
        }

        public ActionResult DragRacing()
        {
            return View();
        }
        public ActionResult Driftmasters()
        {
            return View();
        }
        public ActionResult Formula1History()
        {
            return View();
        }
        public ActionResult StockCarRacing()
        {
            return View();
        }
        public ActionResult WorldEndurance()
        {
            return View();
        }


        //Review Page with commenting section start
        public ActionResult ReviewComments()
        {
            var listofData = _context.Comments.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public dynamic GetViewBag()
        {
            return ViewBag;
        }

        [HttpPost]
        public ActionResult Create(Comment model, dynamic viewBag)
        {
            _context.Comments.Add(model);
            _context.SaveChanges();
            //viewBag.Message = "Comment Inserted Successfully";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.Comments.Where(x => x.userID == id).FirstOrDefault();

            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Comment Model)
        {
            var data = _context.Comments.Where(x =>x.userID == Model.userID).FirstOrDefault();
            if (data != null)
            {
                data.FirstName = Model.FirstName;
                data.LastName = Model.LastName;
                data.City = Model.City;
                data.Question1 = Model.Question1;
                data.Question2 = Model.Question2;
                data.Question3 = Model.Question3;
                _context.SaveChanges();
            }
            return RedirectToAction("ReviewComments");
        }
        public ActionResult Details(int id)
        {
            var data = _context.Comments.Where(x => x.userID == id).FirstOrDefault();
            return View(data);

        }
        public ActionResult Delete(int id)
        {
            var data = _context.Comments.Where(x => x.userID == id).FirstOrDefault();
            _context.Comments.Remove(data);
            _context.SaveChanges();
            ViewBag.Message("Comment Successfully deleted");
            return RedirectToAction("ReviewComments");

        }

        //Review Page with commenting section end
        public ActionResult Facts()
        {
            return View();
        }
    }
}