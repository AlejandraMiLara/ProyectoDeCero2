using Entidades;
using ProyectoDeCero2.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class MateriaNegocios
    {
        private readonly RepositorioMateria _repositorioMateria;

        public MateriaNegocios(RepositorioMateria repositorioMateria)
        {
            _repositorioMateria = repositorioMateria;
        }

        public async Task<List<E_Materia>> BuscarMateriaAsync(string busqueda)
        {
            return await _repositorioMateria.BuscarMateriaAsync(busqueda);
        }

        public async Task EliminarMateriaAsync(int id)
        {
            await _repositorioMateria.EliminarMateriaAsync(id);
        }

        public async Task GuardarMateriaAsync(E_Materia materia)
        {
            if(materia.IdMateria == 0)
            {
                await _repositorioMateria.AgregarMateriaAsync(materia);
            }
            else
            {
                await _repositorioMateria.ActualizarMateriaAsync(materia);
            }
                
        }

        public async Task<E_Materia> ObtenerMateriaPorIdAsync(int id)
        {
            return await _repositorioMateria.ObtenerMateriaPorIdAsync(id);
        }

        public async Task<List<E_Materia>> ObtenerTodasLasMateriasAsync()
        {
            return await _repositorioMateria.ObtenerTodasLasMateriasAsync();
        }
    }
}
