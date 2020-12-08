using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OshawaMechanic.Models
{
    public class OshawaMechanicContext : DbContext
    {
        public OshawaMechanicContext(DbContextOptions<OshawaMechanicContext> options) : base(options)
        {



        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Coustmers> Coustmers { get; set; }

        public DbSet<Assignments> Assignments { get; set; }
    }
}
