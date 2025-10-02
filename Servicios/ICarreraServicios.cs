using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Servicios
{
    public interface ICarreraServicios
    {
        Task<List<E_Carrera>> ObtenerTodasLasCarrerasAsync();
        Task<List<E_Carrera>> BuscarCarrerasAsync(string busqueda);
        Task EliminarCarreraAsync(int id);
        Task GuardarCarreraAsync(E_Carrera carrera);
        Task<E_Carrera> ObtenerCarreraPorIdAsync(int id);
        Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsPlanes);
    }
}
