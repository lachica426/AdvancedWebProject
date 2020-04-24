using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public interface IResponseRepository
    {
        IQueryable<Response> Responses { get; }
        void AddResponse(Response response);
        bool IsRegistered(Response response);
    }
}
