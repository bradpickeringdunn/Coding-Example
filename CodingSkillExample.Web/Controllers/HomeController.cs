using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodingSkillExample.Actions;
using CodingSkillExample.Domain;

namespace CodingSkillExample.Controllers
{
    public class HomeController : Controller
    {
        private ITimeService TimeService;

        public HomeController(){
            //TimeService = new TimeService();
        }

        public HomeController(ITimeService timeService)
        {
            this.TimeService = timeService;
        }

        public ActionResult Index()
        {
            return new GetNextWorkingDayAction<ActionResult>(TimeService)
            {
                OnComplete = (model) => View(model)
            }.Execute(DateTime.Today);
        }

        public ActionResult NextWorkingDay(DateTime? date)
        {
            return new GetNextWorkingDayAction<ActionResult>(TimeService)
            {
                OnComplete = (model) => View("Index",model)
            }.Execute(date);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
