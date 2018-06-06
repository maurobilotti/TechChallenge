using System.Collections.Generic;
using Southworks_TC.Repository;

namespace Southworks_TC.Service
{
    public interface IEventService
    {
        IEnumerable<Event> GetEvents();
    }
}