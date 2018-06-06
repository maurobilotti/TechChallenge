using Southworks_TC.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Southworks_TC.Service
{
    public class EventService
    {
        private EventContext _db;

        public EventService()
        {
            _db = new EventContext();
        }

        public IEnumerable<Event> GetEvents()
        {
            return _db.Event.ToList();
        }
    }
}
