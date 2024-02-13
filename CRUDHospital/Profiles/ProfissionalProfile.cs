using AutoMapper;
using CRUDHospital.Data.Dtos.ProfissionalDto;
using CRUDHospital.Models;

namespace CRUDHospital.Profiles
{
    public class ProfissionalProfile : Profile
    {
        public ProfissionalProfile()
        {
            CreateMap<CreateProfissionalDto, Profissional>();
            CreateMap<Profissional, ReadProfisiionalDto>();
            CreateMap<Profissional, ReadProfissionalIdDto>().ForMember(x => x.ListaConsultas, opt => opt.MapFrom(x => x.ListaConsultas));
            CreateMap<UpdateProfissionalDto, Profissional>().ReverseMap();
        }
    }
}
