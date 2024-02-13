using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Data.Dtos.PacienteDto;

namespace CRUDHospital.Repository.Interfaces
{
    public interface IConsultaRepository
    {
        ReadConsultaIdDto GetConsultaId(int id);
        void AddConsulta(CreateConsultaDto paciente);
        IEnumerable<ReadConsultaDto> GetConsultas();
        void UpdateConsulta(int id, CreateConsultaDto pacienteDto);
        void DeleteConsulta(int id);
    }
}
