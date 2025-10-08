using Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Datos
{
    public class RepositorioNivelAcademico
    {
        private readonly Contexto _contexto;

        public RepositorioNivelAcademico(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task ActualizarNivelAcademicoAsync(E_NivelAcademico nivelAcademico)
        {
            _contexto.Entry(nivelAcademico).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task AgregarNivelAcademicoAsync(E_NivelAcademico nivelAcademico)
        {
            _contexto.NivelesAcademicos.Add(nivelAcademico);
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarNivelAcademicoAsync(int id)
        {
            var nivelAcademico = await _contexto.NivelesAcademicos.FindAsync(id);
            if (nivelAcademico != null)
            {
                _contexto.Remove(nivelAcademico);
                await _contexto.SaveChangesAsync();
            }
        }

        public async Task<E_NivelAcademico> ObtenerNivelAcademicoPorIdAsync(int id)
        {
            return await _contexto.NivelesAcademicos
                .FirstOrDefaultAsync(c => c.IdNivelAcademico == id);
        }

        public async Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync()
        {
            return await _contexto.NivelesAcademicos
                .ToListAsync();
        }
    }
}
