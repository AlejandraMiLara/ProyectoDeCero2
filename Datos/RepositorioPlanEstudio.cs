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
        private readonly Contexto _contexto;

        public RepositorioPlanEstudio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<E_PlanEstudio>> ObtenerTodosAsync()
        {
            return await _contexto.PlanesDeEstudio.Include(p => p.Carrera).ToListAsync();
        }

        public async Task<List<E_PlanEstudio>> ObtenerPlanesPorCarreraIdAsync(int idCarrera)
        {
            return await _contexto.PlanesDeEstudio
                .Where(p => p.IdCarrera == idCarrera)
                .ToListAsync();
        }

        public async Task<E_PlanEstudio> ObtenerPorIdAsync(int id)
        {
            return await _contexto.PlanesDeEstudio.FindAsync(id);
        }

        public async Task AgregarAsync(E_PlanEstudio planEstudio)
        {
            _contexto.PlanesDeEstudio.Add(planEstudio);
            await _contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(E_PlanEstudio planEstudio)
        {
            _contexto.Entry(planEstudio).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var planEstudio = await _contexto.PlanesDeEstudio.FindAsync(id);
            if (planEstudio != null)
            {
                _contexto.PlanesDeEstudio.Remove(planEstudio);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}