using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyVega.Models;

namespace MyVega.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
                new { vf.VehicleId, vf.FeatureId });
        }
    }
    
}