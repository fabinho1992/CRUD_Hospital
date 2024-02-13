using AutoMapper;
using CRUDHospital.Data.Dtos.Especialidade_Profissional;
using CRUDHospital.Migrations;
using CRUDHospital.Models;

namespace CRUDHospital.Profiles
{
    public class EspecialidadeprofissionalProfile : Profile
    {
        public EspecialidadeprofissionalProfile()
        {
            CreateMap<CreateEspecialidade_ProfissionalDto, EspecialidadeProfissionais>().ReverseMap();
            CreateMap<EspecialidadeProfissionais, ReadEspecialidade_ProfissionalDto>().ForMember(x => x.Especialidade, opt => opt.MapFrom(x => x.Especialidade.Nome))
                                                                                   .ForMember(x => x.Profissional, opt => opt.MapFrom(x => x.Profissional.Nome));
        }
    }
}
