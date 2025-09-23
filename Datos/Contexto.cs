using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Datos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<E_Carrera> Carreras { get; set; }
        public DbSet<E_PlanEstudio> PlanesDeEstudio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<E_Carrera>().ToTable("Carrera");
            modelBuilder.Entity<E_PlanEstudio>().ToTable("PlanEstudio");

            // Configuración de la relación
            modelBuilder.Entity<E_PlanEstudio>()
                .HasOne(p => p.Carrera)
                .WithMany()
                .HasForeignKey(p => p.IdCarrera);
        }
    }
}