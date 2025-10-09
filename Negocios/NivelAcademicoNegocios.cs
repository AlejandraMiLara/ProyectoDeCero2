using Entidades;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NivelAcademicoNegocios
    {
        private readonly RepositorioNivelAcademico _repositorioNivelAcademico;

        public NivelAcademicoNegocios(RepositorioNivelAcademico repositorioNivelAcademico)
        {
            _repositorioNivelAcademico = repositorioNivelAcademico;
        }

        public async Task EliminarNivelAcademicoAsync(int id)
        {
            await _repositorioNivelAcademico.EliminarNivelAcademicoAsync(id);
        }

        public async Task GuardarNivelAcademicoAsync(E_NivelAcademico nivelAcademico)
        {
            if (nivelAcademico.IdNivelAcademico == 0)
            {
                await _repositorioNivelAcademico.AgregarNivelAcademicoAsync(nivelAcademico);
            }
            else
            {
                await _repositorioNivelAcademico.ActualizarNivelAcademicoAsync(nivelAcademico);
            }
        }

        public async Task<E_NivelAcademico> ObtenerNivelAcademicoPorIdAsync(int id)
        {
            return await _repositorioNivelAcademico.ObtenerNivelAcademicoPorIdAsync(id);
        }

        public Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync()
        {
            return _repositorioNivelAcademico.ObtenerTodosLosNivelesAcademicosAsync();
        }

    }
}
