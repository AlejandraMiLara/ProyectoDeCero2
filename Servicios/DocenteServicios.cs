using Entidades;
using Negocios;
using Servicios.DTOs;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public DocenteServicios(DocenteNegocios docenteNegocios, IMapper mapper)
        {
            _docenteNegocios = docenteNegocios;
            _mapper = mapper;
        }

        public async Task<List<DocenteDto>> BuscarDocenteAsync(string busqueda)
        {
            var docenteEntidades = await _docenteNegocios.BuscarDocenteAsync(busqueda);
            return _mapper.Map<List<DocenteDto>>(busqueda);
        }

        public async Task EliminarDocenteAsync(int id)
        {
            await _docenteNegocios.EliminarDocenteAsync(id);
        }

        public async Task GuardarDocenteAsync(DocenteDto docente)
        {
            var docenteEntidad = _mapper.Map<E_Docente>(docente);
            await _docenteNegocios.GuardarDocenteAsync(docenteEntidad);
        }

        public async Task<DocenteDto> ObtenerDocentePorIdAsync(int id)
        {
            var docenteEntidad = await _docenteNegocios.ObtenerDocentePorIdAsync(id);
            return _mapper.Map<DocenteDto>(docenteEntidad);
        }

        public async Task<List<DocenteDto>> ObtenerTodosLosDocentesAsync()
        {
            var docentesEntidades = await _docenteNegocios.ObtenerTodosLosDocentesAsync();
            return _mapper.Map<List<DocenteDto>>(docentesEntidades);
        }
    }
}
