using ProyectoDeCero2.Datos;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Datos
{
    public class RepositorioCarrera
    {
        private readonly IDbContextFactory<Contexto> _contextFactory;

        public RepositorioCarrera(IDbContextFactory<Contexto> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<E_Carrera>> ObtenerTodasAsync()
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.Carreras
                .Include(c => c.PlanesDeEstudio)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<E_Carrera> ObtenerPorIdAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.Carreras
                .Include(c => c.PlanesDeEstudio)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.IdCarrera == id);
        }

        public async Task AgregarAsync(E_Carrera carrera)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();
            contexto.Carreras.Add(carrera);
            await contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(E_Carrera carrera)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();
            contexto.Carreras.Update(carrera);
            await contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            var carrera = await contexto.Carreras.FindAsync(id);
            if (carrera != null)
            {
                contexto.Carreras.Remove(carrera);
                await contexto.SaveChangesAsync();
            }
        }

        public async Task<List<E_Carrera>> BuscarAsync(string busqueda)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.Carreras
                .Where(c => c.NombreCarrera.Contains(busqueda) || c.ClaveCarrera.Contains(busqueda))
                .Include(c => c.PlanesDeEstudio)
                .AsNoTracking()
                .ToListAsync();
        }


        public async Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsNuevosPlanes)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            var carrera = await contexto.Carreras
                .Include(c => c.PlanesDeEstudio)
                .FirstOrDefaultAsync(c => c.IdCarrera == idCarrera);

            if (carrera == null)
            {
                return;
            }

            var nuevosPlanes = await contexto.PlanesDeEstudio
                .Where(p => idsNuevosPlanes.Contains(p.IdPlanEstudio))
                .ToListAsync();

            carrera.PlanesDeEstudio = nuevosPlanes;

            await contexto.SaveChangesAsync();
        }
    }
}