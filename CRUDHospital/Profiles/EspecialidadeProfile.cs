using AutoMapper;
using CRUDHospital.Data.Dtos.EspecialidadeDto;
using CRUDHospital.Models;

namespace CRUDHospital.Profiles
{
    public class EspecialidadeProfile : Profile
    {
        public EspecialidadeProfile()
        {
            CreateMap<CreateEspecialidadeDto, Especialidade>().ReverseMap();
            CreateMap<Especialidade, ReadEspecialidadeDto>();
        }
    }
}
