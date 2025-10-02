using ProyectoDeCero2.Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Negocios
{
    public class CarreraNegocios
    {
        private readonly RepositorioCarrera _repositorioCarrera;

        public CarreraNegocios(RepositorioCarrera repositorioCarrera)
        {
            _repositorioCarrera = repositorioCarrera;
        }

        public async Task<List<E_Carrera>> ObtenerTodasLasCarrerasAsync()
        {
            return await _repositorioCarrera.ObtenerTodasAsync();
        }

        public async Task<List<E_Carrera>> BuscarCarrerasAsync(string busqueda)
        {
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                return await _repositorioCarrera.ObtenerTodasAsync();
            }
            return await _repositorioCarrera.BuscarAsync(busqueda);
        }

        public async Task EliminarCarreraAsync(int id)
        {

            await _repositorioCarrera.EliminarAsync(id);
        }

        public async Task GuardarCarreraAsync(E_Carrera carrera)
        {
            if (carrera.IdCarrera == 0)
            {
                await _repositorioCarrera.AgregarAsync(carrera);
            }
            else
            {
                await _repositorioCarrera.ActualizarAsync(carrera);
            }
        }

        public async Task<E_Carrera> ObtenerCarreraPorIdAsync(int id)
        {
            return await _repositorioCarrera.ObtenerPorIdAsync(id);
        }

        public async Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsPlanes)
        {
            await _repositorioCarrera.ActualizarPlanesDeCarreraAsync(idCarrera, idsPlanes);
        }
    }
}
