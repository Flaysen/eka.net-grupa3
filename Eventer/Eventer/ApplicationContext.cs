using Eventer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventer
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Event> Locations { get; set; }

        public DbSet<Event> Organizers { get; set; }

        public DbSet<Event> Users { get; set; }


    }
}
