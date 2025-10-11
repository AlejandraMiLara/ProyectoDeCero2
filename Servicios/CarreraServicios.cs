using ProyectoDeCero2.Negocios;
using ProyectoDeCero2.Servicios;
using Servicios.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Servicios
{
    public class CarreraServicios : ICarreraServicios
    {
        private readonly CarreraNegocios _carreraNegocios;
        private readonly IMapper _mapper;

        public CarreraServicios(CarreraNegocios carreraNegocios, IMapper mapper)
        {
            _carreraNegocios = carreraNegocios;
            _mapper = mapper;
        }

        public async Task<List<CarreraListadoDto>> ObtenerTodasLasCarrerasAsync()
        {
            var carrerasEntidades = await _carreraNegocios.ObtenerTodasLasCarrerasAsync();
            return _mapper.Map<List<CarreraListadoDto>>(carrerasEntidades);
        }

        public async Task<List<CarreraListadoDto>> BuscarCarrerasAsync(string busqueda)
        {
            var carrerasEntidades = await _carreraNegocios.BuscarCarrerasAsync(busqueda);
            return _mapper.Map<List<CarreraListadoDto>>(carrerasEntidades);
        }

        public async Task EliminarCarreraAsync(int id)
        {
            await _carreraNegocios.EliminarCarreraAsync(id);
        }

        public async Task GuardarCarreraAsync(CarreraFormDto carreraDto)
        {
            var carreraEntidad = _mapper.Map<E_Carrera>(carreraDto);
            await _carreraNegocios.GuardarCarreraAsync(carreraEntidad);
        }

        public async Task<CarreraFormDto> ObtenerCarreraPorIdAsync(int id)
        {
            var carreraEntidad = await _carreraNegocios.ObtenerCarreraPorIdAsync(id);
            return _mapper.Map<CarreraFormDto>(carreraEntidad);
        }

        public async Task ActualizarPlanesDeCarreraAsync(int idCarrera, List<int> idsPlanes)
        {
            await _carreraNegocios.ActualizarPlanesDeCarreraAsync(idCarrera, idsPlanes);
        }

        public async Task<CarreraGestionPlanesDto> ObtenerCarreraParaGestionarPlanesAsync(int idCarrera)
        {
            var carreraEntidad = await _carreraNegocios.ObtenerCarreraPorIdAsync(idCarrera);
            return _mapper.Map<CarreraGestionPlanesDto>(carreraEntidad);
        }
    }
}
