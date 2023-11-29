using System;
using AutoMapper;
using ProyectoFinalBack;
using ProyectoFinalBack.Controllers;


namespace ProyectoFinalBack.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapeo de Clase a ClaseDto
            CreateMap<Clase, ClaseDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion));

            // Mapeo inverso de ClaseDto a Clase
            CreateMap<ClaseDto, Clase>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion));

            // Mapeo de Socio a SocioDto
            CreateMap<Socio, SocioDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico));
                


            // Mapeo inverso de SocioDto a Socio
            CreateMap<SocioDto, Socio>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico));
                

        }
    }
}

