using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public interface INivelAcademicoServicios
    {
        Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync();
        Task<E_NivelAcademico> ObtenerNivelAcademicoPorIdAsync(int id);
        Task GuardarNivelAcademicoAsync(E_NivelAcademico nivelAcademico);
        Task EliminarNivelAcademicoAsync(int id);
    }
}
