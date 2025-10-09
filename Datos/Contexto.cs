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

        public DbSet<E_Materia> Materias { get; set; }

        public DbSet<E_Docente> Docentes { get; set; }

        public DbSet<E_NivelAcademico> NivelesAcademicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<E_Carrera>().ToTable("Carrera");
            modelBuilder.Entity<E_PlanEstudio>().ToTable("PlanEstudio");
            modelBuilder.Entity<E_Materia>().ToTable("Materia");
            modelBuilder.Entity<E_Docente>().ToTable("Docente");
            modelBuilder.Entity<E_NivelAcademico>().ToTable("NivelAcademico");

            // config relat.
            modelBuilder.Entity<E_Carrera>()
                .HasMany(c => c.PlanesDeEstudio)
                .WithMany(p => p.Carreras) 
                .UsingEntity(j => j.ToTable("CarreraPlanEstudio"));

            modelBuilder.Entity<E_Materia>()
                .HasOne(m => m.NivelAcademico)
                .WithMany(n => n.Materias)
                .HasForeignKey(m => m.IdNivelAcademico)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}