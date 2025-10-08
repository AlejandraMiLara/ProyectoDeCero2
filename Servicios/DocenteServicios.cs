using Datos.Migrations;
using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DocenteServicios : IDocenteServicios
    {
        private readonly DocenteNegocios _docenteNegocios;

        public DocenteServicios(DocenteNegocios docenteNegocios)
        {
            _docenteNegocios = docenteNegocios;
        }

        public async Task<List<E_Docente>> BuscarDocenteAsync(string busqueda)
        {
            return await _docenteNegocios.BuscarDocenteAsync(busqueda);
        }

        public async Task EliminarDocenteAsync(int id)
        {
            await _docenteNegocios.EliminarDocenteAsync(id);
        }

        public async Task GuardarDocenteAsync(E_Docente docente)
        {
            await _docenteNegocios.GuardarDocenteAsync(docente);
        }

        public async Task<E_Docente> ObtenerDocentePorIdAsync(int id)
        {
            return await _docenteNegocios.ObtenerDocentePorIdAsync(id);
        }

        public async Task<List<E_Docente>> ObtenerTodosLosDocentesAsync()
        {
            return await _docenteNegocios.ObtenerTodosLosDocentesAsync();
        }
    }
}
