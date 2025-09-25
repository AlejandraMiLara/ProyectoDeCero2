using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Servicios
{
    public interface IPlanEstudioServicios
    {
        Task<List<E_PlanEstudio>> ObtenerTodosLosPlanesAsync();
        Task<E_PlanEstudio> ObtenerPlanPorIdAsync(int id);
        Task GuardarPlanAsync(E_PlanEstudio planEstudio);
        Task EliminarPlanAsync(int id);
        Task<List<E_PlanEstudio>> ObtenerPlanesPorCarreraAsync(int idCarrera);
    }
}