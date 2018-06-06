using Southworks_TC.Models;
using Southworks_TC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Southworks_TC.Controllers
{
    public class EventController : Controller
    {
        private IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Load()
        {
            var events = _service.GetEvents().Select(e => new EventViewModel(e));
            var returnType = new ReturnType(events);
            return Json(new { data = events }, JsonRequestBehavior.AllowGet);
        }

        public class ReturnType
        {
            public IEnumerable<EventViewModel> Data { get; set; }
            public ReturnType(IEnumerable<EventViewModel> _data)
            {
                Data = _data;
            }
        }
    }
}