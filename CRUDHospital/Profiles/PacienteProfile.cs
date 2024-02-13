using AutoMapper;
using CRUDHospital.Data.Dtos.PacienteDto;
using CRUDHospital.Models;

namespace CRUDHospital.Profiles
{
    public class PacienteProfile : Profile
    {
        public PacienteProfile()
        {
            CreateMap<CreatePacienteDto, Paciente>();
            CreateMap <Paciente, ReadpacienteDto>();
            CreateMap<Paciente, ReadPacienteDtoId>().ForMember(x => x.ListaConsultas, opt => opt.MapFrom(x => x.ListaConsultas));
            CreateMap<UpdatePacienteDto, Paciente>().ReverseMap();
        }
    }
}
