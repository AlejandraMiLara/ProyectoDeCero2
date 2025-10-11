using Entidades;
using Microsoft.EntityFrameworkCore;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioDocente
    {
        private readonly IDbContextFactory<Contexto> _contextFactory;

        public RepositorioDocente(IDbContextFactory<Contexto> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task ActualizarDocenteAsync(E_Docente docente)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();
            contexto.Docentes.Update(docente);
            await contexto.SaveChangesAsync();
        }

        public async Task AgregarDocenteAsync(E_Docente docente)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();
            contexto.Docentes.Add(docente);
            await contexto.SaveChangesAsync();
        }

        public async Task<List<E_Docente>> BuscarDocenteAsync(string busqueda)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();
            return await contexto.Docentes
                .Where(c => c.NumeroEmpleadoDocente.Contains(busqueda) || c.NombreDocente.Contains(busqueda) || c.ApMatDocente.Contains(busqueda) || c.ApPatDocente.Contains(busqueda))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task EliminarDocenteAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            var docente = await contexto.Docentes.FindAsync(id);
            if (docente != null)
            {
                contexto.Docentes.Remove(docente);
                await contexto.SaveChangesAsync();
            }
        }

        public async Task<E_Docente> ObtenerDocentePorIdAsync(int id)
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.Docentes
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.IdDocente == id);
        }

        public async Task<List<E_Docente>> ObtenerTodosLosDocentesAsync()
        {
            await using var contexto = await _contextFactory.CreateDbContextAsync();

            return await contexto.Docentes
                .AsNoTracking()
                .ToListAsync();
        }


    }
}
