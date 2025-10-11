using Microsoft.EntityFrameworkCore;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Datos
{
    public class RepositorioPlanEstudio
    {
        private readonly IDbContextFactory<Contexto> _contextFactory;

        public RepositorioPlanEstudio(IDbContextFactory<Contexto> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<E_PlanEstudio>> ObtenerTodosAsync()
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.PlanesDeEstudio.Include(p => p.Carreras)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<E_PlanEstudio>> ObtenerPlanesPorCarreraIdAsync(int idCarrera)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.PlanesDeEstudio
                .Where(p => p.Carreras.Any(c => c.IdCarrera == idCarrera))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<E_PlanEstudio> ObtenerPorIdAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.PlanesDeEstudio
                .Include(p => p.Carreras)
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.IdPlanEstudio == id);
        }

        public async Task AgregarAsync(E_PlanEstudio planEstudio)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            contexto.PlanesDeEstudio.Add(planEstudio);
            await contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(E_PlanEstudio planEstudio)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            contexto.PlanesDeEstudio.Update(planEstudio);
            await contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            var planEstudio = await contexto.PlanesDeEstudio.FindAsync(id);
            if (planEstudio != null)
            {
                contexto.PlanesDeEstudio.Remove(planEstudio);
                await contexto.SaveChangesAsync();
            }
        }
    }
}