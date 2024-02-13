using CRUDHospital.Data.Dtos.EspecialidadeDto;
using CRUDHospital.Data.Dtos.PacienteDto;

namespace CRUDHospital.Repository.Interfaces
{
    public interface IEspecialidadeRepository
    {

        ReadEspecialidadeIdDto GetEspecialidadeId(int id);
        void AddEspecialidade(CreateEspecialidadeDto especialidadeDto);
        IEnumerable<ReadEspecialidadeDto> GetEspecialidades();
        void UpdateEspecialidade(int id, CreateEspecialidadeDto especialidadeDto);
        void DeleteEspecialidade(int id);
    }
}
