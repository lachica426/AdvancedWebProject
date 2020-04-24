using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class EFResponseRepository : IResponseRepository
    {
        private ApplicationDbContext context;
        public EFResponseRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Response> Responses => context.Responses;

        public void AddResponse(Response response)
        {
            context.Responses.Add(response);
            context.SaveChanges();
        }

        public bool IsRegistered(Response response)
        {
            Response dbEntry = context.Responses
            .FirstOrDefault(r => r.EventID == response.EventID && r.Email == response.Email);
            if (dbEntry != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
