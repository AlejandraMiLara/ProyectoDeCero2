using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Servicios
{
    public interface ICarreraServicios
    {
        Task<List<CarreraListadoDto>> ObtenerTodasLasCarrerasAsync();
        Task<List<CarreraListadoDto>> BuscarCarrerasAsync(string busqueda);
        Task EliminarCarreraAsync(int id);
        Task GuardarCarreraAsync(CarreraFormDto carrera);
        Task<CarreraFormDto> ObtenerCarreraPorIdAsync(int id);
        Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsPlanes);
        Task<CarreraGestionPlanesDto> ObtenerCarreraParaGestionarPlanesAsync(int idCarrera);
    }
}
