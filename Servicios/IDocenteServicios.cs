using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.DTOs;

namespace Servicios
{
    public interface IDocenteServicios
    {
        Task<List<DocenteDto>> ObtenerTodosLosDocentesAsync();
        Task<List<DocenteDto>> BuscarDocenteAsync(string busqueda);
        Task<DocenteDto> ObtenerDocentePorIdAsync(int id);
        Task GuardarDocenteAsync(DocenteDto docente);
        Task EliminarDocenteAsync(int id);
    }
}
