using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<E_Carrera> Carreras { get; set; }
        public DbSet<E_PlanEstudio> PlanesEstudio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<E_Carrera>().ToTable("Carrera");
            modelBuilder.Entity<E_PlanEstudio>().ToTable("PlanEstudio");

            modelBuilder.Entity<E_PlanEstudio>()
                .HasOne(pe => pe.Carrera)
                .WithMany()
                .HasForeignKey(pe => pe.IdCarrera);
        }
    }
}
