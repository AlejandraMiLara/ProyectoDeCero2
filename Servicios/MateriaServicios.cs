using Entidades;
using Negocios;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class MateriaServicios : IMateriaServicios
    {
        private readonly MateriaNegocios _materiaNegocios;

        public MateriaServicios(MateriaNegocios materiaNegocios)
        {
            _materiaNegocios = materiaNegocios;
        }

        public async Task<List<E_Materia>> BuscarMateriaAsync(string busqueda)
        {
            return await _materiaNegocios.BuscarMateriaAsync(busqueda);
        }

        public async Task EliminarMateriaAsync(int id)
        {
            await _materiaNegocios.EliminarMateriaAsync(id);
        }

        public async Task GuardarMateriaAsync(E_Materia materia)
        {
            await _materiaNegocios.GuardarMateriaAsync(materia);
        }

        public async Task<E_Materia> ObtenerMateriaPorIdAsync(int id)
        {
            return await _materiaNegocios.ObtenerMateriaPorIdAsync(id);
        }

        public async Task<List<E_Materia>> ObtenerTodasLasMateriasAsync()
        {
            return await _materiaNegocios.ObtenerTodasLasMateriasAsync();
        }

        public async Task<List<E_NivelAcademico>> ObtenerTodosLosNivelesAcademicosAsync()
        {
            return await _materiaNegocios.ObtenerTodosLosNivelesAcademicosAsync();
        }
    }
}
