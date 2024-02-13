using AutoMapper;
using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Models;

namespace CRUDHospital.Profiles
{
    public class ConsultaProfile : Profile
    {
        public ConsultaProfile()
        {
            CreateMap<CreateConsultaDto, Consulta>().ReverseMap();
            CreateMap<Consulta, ReadConsultaDto>();
            CreateMap<Consulta, ReadConsultaIdDto>().ForMember(x => x.Especialidade, opt => opt.MapFrom(x => x.Especialidade.Nome))
                                                    .ForMember(x => x.Profissional, opt => opt.MapFrom(x => x.Profissional.Nome))
                                                    .ForMember(x => x.Paciente, opt => opt.MapFrom(x => x.Paciente.Nome));
            CreateMap<Consulta, ReadConsultaDelahesProfissionalDto>().ForMember(x => x.Paciente, opt => opt.MapFrom(x => x.Paciente.Nome));
        }
    }
}
