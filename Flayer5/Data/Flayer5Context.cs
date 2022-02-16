using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Flayer5.Models;

namespace Flayer5.Data
{
    public class Flayer5Context : DbContext
    {
        public Flayer5Context (DbContextOptions<Flayer5Context> options)
            : base(options)
        {
        }

        public DbSet<Flayer5.Models.Bilet> Bilet { get; set; }

        public DbSet<Flayer5.Models.Companie> Companie { get; set; }

        public DbSet<Flayer5.Models.Pachet> Pachet { get; set; }
    }
}
