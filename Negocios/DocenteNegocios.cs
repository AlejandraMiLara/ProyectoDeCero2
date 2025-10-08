using Datos;
using Datos.Migrations;
using Entidades;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class DocenteNegocios
    {

        private readonly RepositorioDocente _repositorioDocente;

        public DocenteNegocios(RepositorioDocente repositorioDocente)
        {
            _repositorioDocente = repositorioDocente;
        }

        public async Task<List<E_Docente>> BuscarDocenteAsync(string busqueda)
        {
            return await _repositorioDocente.BuscarDocenteAsync(busqueda);
        }

        public async Task EliminarDocenteAsync(int id)
        {
            await _repositorioDocente.EliminarDocenteAsync(id);
        }

        public async Task GuardarDocenteAsync(E_Docente docente)
        {
            if (docente.IdDocente == 0)
            {
                await _repositorioDocente.AgregarDocenteAsync(docente);
            }
            else
            {
                await _repositorioDocente.ActualizarDocenteAsync(docente);
            }
        }

        public async Task<E_Docente> ObtenerDocentePorIdAsync(int id)
        {
            return await _repositorioDocente.ObtenerDocentePorIdAsync(id);
        }

        public async Task<List<E_Docente>> ObtenerTodosLosDocentesAsync()
        {
            return await _repositorioDocente.ObtenerTodosLosDocentesAsync();
        }
    }
}
