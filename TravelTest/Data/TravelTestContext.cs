using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelTest.Models
{
    public class TravelTestContext : DbContext
    {
        public TravelTestContext (DbContextOptions<TravelTestContext> options)
            : base(options)
        {
        }

        public DbSet<TravelTest.Models.Place> Place { get; set; }
    }
}
