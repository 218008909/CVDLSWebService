using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CVDLS.Models;

namespace CVDLS.Data
{
    public class CVDLSContext : DbContext
    {
        public CVDLSContext (DbContextOptions<CVDLSContext> options)
            : base(options)
        {
        }

        public DbSet<CVDLS.Models.Location> Location { get; set; }

        public DbSet<CVDLS.Models.Stock> Stock { get; set; }
    }
}
