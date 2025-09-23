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
        private readonly Contexto _contexto;

        public RepositorioCarrera(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<E_Carrera>> ObtenerTodasAsync()
        {
            return await _contexto.Carreras.ToListAsync();
        }

        public async Task<E_Carrera> ObtenerPorIdAsync(int id)
        {
            return await _contexto.Carreras.FindAsync(id);
        }

        public async Task AgregarAsync(E_Carrera carrera)
        {
            _contexto.Carreras.Add(carrera);
            await _contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(E_Carrera carrera)
        {
            _contexto.Entry(carrera).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var carrera = await _contexto.Carreras.FindAsync(id);
            if (carrera != null)
            {
                _contexto.Carreras.Remove(carrera);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<List<E_Carrera>> BuscarAsync(string busqueda)
        {
            return await _contexto.Carreras
                .Where(c => c.NombreCarrera.Contains(busqueda) || c.ClaveCarrera.Contains(busqueda))
                .ToListAsync();
        }
    }
}