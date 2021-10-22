using Medivis.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medivis.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

        public DbSet<Cita> Cita { get; set; }
        public DbSet<Persona> Personas { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().HasIndex(x => x.NumeroDocumento).IsUnique();
            modelBuilder.Entity<Cita>().HasIndex(x => x.Doctor).IsUnique();
        }
    }
}
