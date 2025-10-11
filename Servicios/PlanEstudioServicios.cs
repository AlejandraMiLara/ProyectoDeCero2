using Entidades;
using AutoMapper;
using Servicios.DTOs;
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
        private readonly IMapper _mapper;

        public PlanEstudioServicios(PlanEstudioNegocios planEstudioNegocios, IMapper mapper)
        {
            _planEstudioNegocios = planEstudioNegocios;
            _mapper = mapper;
        }

        public async Task<List<PlanEstudioFormDto>> ObtenerTodosLosPlanesAsync()
        {
            var peEntidades = await _planEstudioNegocios.ObtenerTodosLosPlanesAsync();
            return _mapper.Map<List<PlanEstudioFormDto>>(peEntidades);
        }

        public async Task<PlanEstudioFormDto> ObtenerPlanPorIdAsync(int id)
        {
            var peEntidades = await _planEstudioNegocios.ObtenerPlanPorIdAsync(id);
            return _mapper.Map<PlanEstudioFormDto>(peEntidades);
        }

        public async Task GuardarPlanAsync(PlanEstudioFormDto planEstudioDto)
        {
            var peEntidad = _mapper.Map<E_PlanEstudio>(planEstudioDto);
            await _planEstudioNegocios.GuardarPlanAsync(peEntidad);
        }

        public async Task EliminarPlanAsync(int id)
        {
            await _planEstudioNegocios.EliminarPlanAsync(id);
        }

        public async Task<List<PlanEstudioFormDto>> ObtenerPlanesPorCarreraAsync(int idCarrera)
        {
            var peEntidades = await _planEstudioNegocios.ObtenerPlanesPorCarreraAsync(idCarrera);
            return _mapper.Map<List<PlanEstudioFormDto>>(peEntidades);
        }
    }
}