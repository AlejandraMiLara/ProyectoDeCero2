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
        private readonly Contexto _contexto;

        public RepositorioDocente(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task ActualizarDocenteAsync(E_Docente docente)
        {
            _contexto.Entry(docente).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task AgregarDocenteAsync(E_Docente docente)
        {
            _contexto.Docentes.Add(docente);
            await _contexto.SaveChangesAsync();
        }

        public async Task<List<E_Docente>> BuscarDocenteAsync(string busqueda)
        {
            return await _contexto.Docentes
                .Where(c => c.NumeroEmpleadoDocente.Contains(busqueda) || c.NombreDocente.Contains(busqueda) || c.ApMatDocente.Contains(busqueda) || c.ApPatDocente.Contains(busqueda))
                .ToListAsync();
        }

        public async Task EliminarDocenteAsync(int id)
        {
            var docente = await _contexto.Docentes.FindAsync(id);
            if (docente != null)
            {
                _contexto.Docentes.Remove(docente);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<E_Docente> ObtenerDocentePorIdAsync(int id)
        {
            return await _contexto.Docentes
                .FirstOrDefaultAsync(c => c.IdDocente == id);
        }

        public async Task<List<E_Docente>> ObtenerTodosLosDocentesAsync()
        {
            return await _contexto.Docentes
                .ToListAsync();
        }


    }
}
