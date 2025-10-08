using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class NivelAcademicoServicios : INivelAcademicoServicios
    {

        private readonly NivelAcademicoNegocios _nivelAcademicoNegocios;

        public NivelAcademicoServicios(NivelAcademicoNegocios nivelAcademicoNegocios)
        {
            _nivelAcademicoNegocios = nivelAcademicoNegocios;
        }


        public async Task EliminarNivelAcademicoAsync(int id)
        {
            await _nivelAcademicoNegocios.EliminarNivelAcademicoAsync(id);
        }

        public async Task GuardarNivelAcademicoAsync(E_NivelAcademico nivelAcademico)
        {
            await _nivelAcademicoNegocios.GuardarNivelAcademicoAsync(nivelAcademico);
        }

        public async Task<E_NivelAcademico> ObtenerNivelAcademicoPorIdAsync(int id)
        {
            return await _nivelAcademicoNegocios.ObtenerNivelAcademicoPorIdAsync(id);
        }

        public Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync()
        {
            return _nivelAcademicoNegocios.ObtenerTodosLosNivelesAcademicosAsync();
        }
    }
}
