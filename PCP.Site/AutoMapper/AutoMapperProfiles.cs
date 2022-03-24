using AutoMapper;
using PCP.Domain.Entities;
using PCP.Site.ViewModels;

namespace PCP.Site.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Disponibilidade_Fisica, Disponibilidade_FisicaDto>();
            CreateMap<Disponibilidade_FisicaDto, Disponibilidade_Fisica>();
            CreateMap<TrocasxSurgimentoVigente, TrocasxSurgimentoVigenteDto>();
            CreateMap<TrocasxSurgimentoVigenteDto, TrocasxSurgimentoVigente>();
        }
    }
}