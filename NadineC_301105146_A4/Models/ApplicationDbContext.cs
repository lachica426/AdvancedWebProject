/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.EntityFrameworkCore;
using NadineC_301105146_A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Player> Players { get; set; }
        
        public DbSet<Event> Events { get; set; }

        public DbSet<Response> Responses { get; set; }
    }
}
