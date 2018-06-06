using Southworks_TC.Models;
using Southworks_TC.Service;
using System.Linq;
using System.Web.Mvc;

namespace Southworks_TC.Controllers
{
    [HandleError]
    public class EventController : Controller
    {
        private IEventService _service;

        public EventController(IEventService service)
        {
            _service = service;
        }

        // GET: Event
        [Route("Event/Index")]
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// returns the events from the DB to the view via AJAX GET request
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile = "CacheEvents")]  //added by statement
        public ActionResult Load()
        {
            var events = _service.GetEvents().Select(e => new EventViewModel(e));            
            return Json(new { data = events }, JsonRequestBehavior.AllowGet);
        }       
    }
}