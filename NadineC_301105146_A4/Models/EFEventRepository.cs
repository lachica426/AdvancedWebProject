using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class EFEventRepository : IEventRepository
    {
        private ApplicationDbContext context;
        public EFEventRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Event> Events => 
            context.Events
            .Include("Responses")
            .AsQueryable<Event>();

        public void SaveEvent(Event events) //will add or update the club
        {
            if (events.EventID == 0)
            {
                context.Events.Add(events);
            }
            else
            {
                Event dbEntry = context.Events
                .FirstOrDefault(e => e.EventID == events.EventID);
                if (dbEntry != null)
                {
                    dbEntry.EventName = events.EventName;
                    dbEntry.Description = events.Description;
                    dbEntry.EventDate = events.EventDate;
                    dbEntry.Venue = events.Venue;
                }
            }
            context.SaveChanges();
        }

        public Event DeleteEvent(int eventID) //will delete the Event
        {
            Event dbEntry = context.Events
            .FirstOrDefault(e => e.EventID == eventID);
            if (dbEntry != null)
            {
                context.Events.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public Event GetEvent(int eventID) //displays event
        {
            return context.Events
                .Include("Responses")
                .FirstOrDefault(e => e.EventID == eventID);
        }

        //public int GetEventResponse(int eventID) //displays event
        //{
        //    return context.Events
        //        .Include("Responses")
        //        .Where(e => e.EventID == eventID)
        //        .Count<Event>();
        //}
    }
}
