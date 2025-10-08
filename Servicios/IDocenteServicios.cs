using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public interface IDocenteServicios
    {
        Task<List<E_Docente>> ObtenerTodosLosDocentesAsync();
        Task<List<E_Docente>> BuscarDocenteAsync(string busqueda);
        Task<E_Docente> ObtenerDocentePorIdAsync(int id);
        Task GuardarDocenteAsync(E_Docente docente);
        Task EliminarDocenteAsync(int id);
    }
}
