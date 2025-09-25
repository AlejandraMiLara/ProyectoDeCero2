using Entidades;
using ProyectoDeCero2.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoDeCero2.Servicios
{
    public class PlanEstudioServicios : IPlanEstudioServicios
    {
        private readonly PlanEstudioNegocios _planEstudioNegocios;

        public PlanEstudioServicios(PlanEstudioNegocios planEstudioNegocios)
        {
            _planEstudioNegocios = planEstudioNegocios;
        }

        public async Task<List<E_PlanEstudio>> ObtenerTodosLosPlanesAsync()
        {
            return await _planEstudioNegocios.ObtenerTodosLosPlanesAsync();
        }

        public async Task<E_PlanEstudio> ObtenerPlanPorIdAsync(int id)
        {
            return await _planEstudioNegocios.ObtenerPlanPorIdAsync(id);
        }

        public async Task GuardarPlanAsync(E_PlanEstudio planEstudio)
        {
            await _planEstudioNegocios.GuardarPlanAsync(planEstudio);
        }

        public async Task EliminarPlanAsync(int id)
        {
            await _planEstudioNegocios.EliminarPlanAsync(id);
        }

        public async Task<List<E_PlanEstudio>> ObtenerPlanesPorCarreraAsync(int idCarrera)
        {
            return await _planEstudioNegocios.ObtenerPlanesPorCarreraAsync(idCarrera);
        }
    }
}