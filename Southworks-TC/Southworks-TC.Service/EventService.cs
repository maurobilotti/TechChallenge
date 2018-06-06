using Southworks_TC.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Southworks_TC.Service
{
    public class EventService : IEventService
    {
        private Entities _db;

        public EventService()
        {
            _db = new Entities();
        }

        public IEnumerable<Event> GetEvents()
        {
            List<Event> result = new List<Event>();

            try
            {
                result = _db.Event.Take(1000).ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
