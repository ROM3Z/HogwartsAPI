using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HogwartsAPI.Models;

namespace HogwartsAPI.Models
{
    public class HogwartsAPIContext : DbContext
    {
        public HogwartsAPIContext (DbContextOptions<HogwartsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HogwartsAPI.Models.Aspirantes> Aspirantes { get; set; }
    }
}
