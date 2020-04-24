using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public interface IEventRepository
    {
        IQueryable<Event> Events { get; }

        void SaveEvent(Event events);

        Event DeleteEvent(int eventID);

        Event GetEvent(int eventID);
    }
}
