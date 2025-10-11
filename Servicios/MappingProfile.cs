using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entidades;
using Servicios.DTOs;

namespace Servicios
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<E_PlanEstudio, PlanEstudioResumenDto>();
            CreateMap<E_PlanEstudio, PlanEstudioFormDto>();
            CreateMap<E_PlanEstudio, PlanEstudioListadoDto>();
            CreateMap<PlanEstudioFormDto, E_PlanEstudio>();

            CreateMap<E_Carrera, CarreraGestionPlanesDto>()
                .ForMember(dest => dest.IdsPlanesEstudio,
                    opt => opt.MapFrom(src => src.PlanesDeEstudio.Select(p => p.IdPlanEstudio).ToList()));

            CreateMap<E_Carrera, CarreraFormDto>();
            CreateMap<E_Carrera, CarreraListadoDto>();
            CreateMap<CarreraFormDto, E_Carrera>();

            CreateMap<E_Docente, DocenteDto>();
            CreateMap<DocenteDto, E_Docente>();


        }


    }
}
