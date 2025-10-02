using Entidades;
using ProyectoDeCero2.Negocios;
using ProyectoDeCero2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CarreraServicios : ICarreraServicios
    {
        private readonly CarreraNegocios _carreraNegocios;

        public CarreraServicios(CarreraNegocios carreraNegocios)
        {
            _carreraNegocios = carreraNegocios;
        }

        public async Task<List<E_Carrera>> ObtenerTodasLasCarrerasAsync()
        {
            return await _carreraNegocios.ObtenerTodasLasCarrerasAsync();
        }

        public async Task<List<E_Carrera>> BuscarCarrerasAsync(string busqueda)
        {
            return await _carreraNegocios.BuscarCarrerasAsync(busqueda);
        }

        public async Task EliminarCarreraAsync(int id)
        {
            await _carreraNegocios.EliminarCarreraAsync(id);
        }

        public async Task GuardarCarreraAsync(E_Carrera carrera)
        {
            await _carreraNegocios.GuardarCarreraAsync(carrera);
        }

        public async Task<E_Carrera> ObtenerCarreraPorIdAsync(int id)
        {
            return await _carreraNegocios.ObtenerCarreraPorIdAsync(id);
        }

        public async Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsPlanes)
        {
            await _carreraNegocios.ActualizarPlanesDeCarreraAsync(idCarrera, idsPlanes);
        }
    }
}
