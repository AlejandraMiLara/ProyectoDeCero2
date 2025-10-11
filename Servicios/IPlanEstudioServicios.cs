using Servicios.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeCero2.Servicios
{
    public interface IPlanEstudioServicios
    {
        Task<List<PlanEstudioFormDto>> ObtenerTodosLosPlanesAsync();
        Task<PlanEstudioFormDto> ObtenerPlanPorIdAsync(int id);
        Task GuardarPlanAsync(PlanEstudioFormDto planEstudio);
        Task EliminarPlanAsync(int id);
        Task<List<PlanEstudioFormDto>> ObtenerPlanesPorCarreraAsync(int idCarrera);
    }
}