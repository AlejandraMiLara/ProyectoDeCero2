using Entidades;
using Microsoft.EntityFrameworkCore;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Datos
{
    public class RepositorioMateria
    {
        private readonly Contexto _contexto;

        public RepositorioMateria(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task ActualizarMateriaAsync(E_Materia materia)
        {
            _contexto.Entry(materia).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task AgregarMateriaAsync(E_Materia materia)
        {
            _contexto.Materias.Add(materia);
            await _contexto.SaveChangesAsync();
        }

        public async Task<List<E_Materia>> BuscarMateriaAsync(string busqueda)
        {
            return await _contexto.Materias
                .Where(c => c.ClaveMateria.Contains(busqueda))
                .ToListAsync();
        }

        public async Task EliminarMateriaAsync(int id)
        {
            var materia = await _contexto.Materias.FindAsync(id);
            if (materia != null)
            {
                _contexto.Materias.Remove(materia);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<E_Materia> ObtenerMateriaPorIdAsync(int id)
        {
            return await _contexto.Materias
                .FirstOrDefaultAsync(c => c.IdMateria == id);
        }

        public async Task<List<E_Materia>> ObtenerTodasLasMateriasAsync()
        {
            return await _contexto.Materias 
                .ToListAsync();
        }
    }
}
