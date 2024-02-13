using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Data.Dtos.Especialidade_Profissional;

namespace CRUDHospital.Repository.Interfaces
{
    public interface IEspecialidadeProfissionalRepository
    {
        
        void Add(CreateEspecialidade_ProfissionalDto dto);
        IEnumerable<ReadEspecialidade_ProfissionalDto> Get();
        void Update(int id, CreateEspecialidade_ProfissionalDto dto);
        void Delete(int id);
    }
}
