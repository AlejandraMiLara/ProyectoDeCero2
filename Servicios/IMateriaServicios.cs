using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public interface IMateriaServicios
    {
        Task<List<E_Materia>> ObtenerTodasLasMateriasAsync();
        Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync();
        Task<List<E_Materia>> BuscarMateriaAsync(string busqueda);
        Task<E_Materia> ObtenerMateriaPorIdAsync(int id);
        Task GuardarMateriaAsync(E_Materia materia);
        Task EliminarMateriaAsync(int id);
    }
}
