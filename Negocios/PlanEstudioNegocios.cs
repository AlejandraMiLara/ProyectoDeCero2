using ProyectoDeCero2.Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoDeCero2.Negocios
{
    public class PlanEstudioNegocios
    {
        private readonly RepositorioPlanEstudio _repositorioPlanEstudio;

        public PlanEstudioNegocios(RepositorioPlanEstudio repositorioPlanEstudio)
        {
            _repositorioPlanEstudio = repositorioPlanEstudio;
        }

        public async Task<List<E_PlanEstudio>> ObtenerTodosLosPlanesAsync()
        {
            return await _repositorioPlanEstudio.ObtenerTodosAsync();
        }

        public async Task<E_PlanEstudio> ObtenerPlanPorIdAsync(int id)
        {
            return await _repositorioPlanEstudio.ObtenerPorIdAsync(id);
        }

        public async Task GuardarPlanAsync(E_PlanEstudio planEstudio)
        {
            if (planEstudio.IdPlanEstudio == 0)
            {
                planEstudio.FechaCreacion = DateTime.Now;
                await _repositorioPlanEstudio.AgregarAsync(planEstudio);
            }
            else
            {
                await _repositorioPlanEstudio.ActualizarAsync(planEstudio);
            }
        }

        public async Task EliminarPlanAsync(int id)
        {
            await _repositorioPlanEstudio.EliminarAsync(id);
        }

        public async Task<List<E_PlanEstudio>> ObtenerPlanesPorCarreraAsync(int idCarrera)
        {
            return await _repositorioPlanEstudio.ObtenerPlanesPorCarreraIdAsync(idCarrera);
        }
    }
}
