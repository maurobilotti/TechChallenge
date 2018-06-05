using Southworks_TC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southworks_TC.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Load()
        {
            //using (MyDatabaseEntities dc = new MyDatabaseEntities())
            //{
            //    // dc.Configuration.LazyLoadingEnabled = false; // if your table is relational, contain foreign key
            //    var data = dc.Customers.OrderBy(a => a.ContactName).ToList();
            //    return Json(new { data = data }, JsonRequestBehavior.AllowGet);
            //}

            var list = new List<EventViewModel>
            {
                new EventViewModel {Id = 1, Title = "Some Title 1", StartingDate = new DateTime().Date, Technology = "Technology 1", RegistrationLink = "RegistrationLink1" },
                new EventViewModel {Id = 2, Title = "Some Title 2", StartingDate = new DateTime().Date, Technology = "Technology 2", RegistrationLink = "RegistrationLink2" },
                new EventViewModel {Id = 3, Title = "Some Title 3", StartingDate = new DateTime().Date, Technology = "Technology 3", RegistrationLink = "RegistrationLink3" },
                new EventViewModel {Id = 4, Title = "Some Title 4", StartingDate = new DateTime().Date, Technology = "Technology 4", RegistrationLink = "RegistrationLink4" },
                new EventViewModel {Id = 5, Title = "Some Title 5", StartingDate = new DateTime().Date, Technology = "Technology 5", RegistrationLink = "RegistrationLink5" },
            };

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}