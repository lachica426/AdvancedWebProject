/* Name: Nadine Castro, Student#: 301105146*/
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NadineC_301105146_A4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadineC_301105146_A4.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
                new Club
                {
                    ClubName = "FC Barcelona",
                    ClubNickName = "Barca",
                    Description = "Football Club Barcelona is a Spanish professional football club based in Barcelona, Catalonia, Spain.",
                    YearFounded = 1899,
                    Coach = "Quique Setien",
                    President = "Josep Maria Bartomeu",
                    Players = new List<Player>()
                    {
                        new Player {FirstName="Lionel", LastName="Messi", Position="Forward", Goals=730},
                        new Player {FirstName="Júnior", LastName="Firpo", Position="Forward", Goals=500 },
                        new Player {FirstName="Jordi", LastName="Alba", Position="Forward", Goals=550},
                        new Player {FirstName="Neto", LastName="NoLastName", Position="Forward", Goals=248 },
                    }
                },
                new Club
                {
                    ClubName = "Toronto Football Club",
                    ClubNickName = "The Reds",
                    Description = "Toronto Football Club is a Canadian professional soccer club based in Toronto, Ontario.",
                    YearFounded = 2005,
                    Coach = "Gregg Vaney",
                    President = "Bill Manning",
                    Players = new List<Player>()
                    {
                        new Player {FirstName="Philip", LastName="Younghusband", Position="Forward" , Goals=135}
                    }
                },
                new Club
                {
                    ClubName = "Real Madrid Club de Futbol",
                    ClubNickName = "La Casa Blanca",
                    Description = "Real Madrid is a Spanish professional football club based in Madrid.",
                    YearFounded = 1902,
                    Coach = "Zinedine Zidane",
                    President = "Florentino Perez",
                    Players = new List<Player>()
                    {
                        new Player {FirstName="Cristiano", LastName="Ronaldo", Position="Forward", Goals=725 }
                    }

                },
                new Club
                {
                    ClubName = "Manchester United",
                    ClubNickName = "The Red Devils",
                    Description = "Manchester United Football Club is a professional football club based in Old Trafford, Greater Manchester, England",
                    YearFounded = 1878,
                    Coach = "Ole Gunnar Solskjær",
                    President = "Avram Glazer",
                    Players = new List<Player>()
                    {
                        new Player {FirstName="David", LastName="Beckham", Position="Forward", Goals=300 }
                    }
                }
                );
                context.SaveChanges();
            }
        }
    }
}
