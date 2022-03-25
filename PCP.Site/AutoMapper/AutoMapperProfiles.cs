using AutoMapper;
using PCP.Domain.Entities;
using PCP.Site.ViewModels;

namespace PCP.Site.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<indisponibilidadectr, Disponibilidade_FisicaDto>();
            CreateMap<Disponibilidade_FisicaDto, indisponibilidadectr>();
            CreateMap<TrocasxSurgimentoVigente, TrocasxSurgimentoVigenteDto>();
            CreateMap<TrocasxSurgimentoVigenteDto, TrocasxSurgimentoVigente>();
        }
    }
}