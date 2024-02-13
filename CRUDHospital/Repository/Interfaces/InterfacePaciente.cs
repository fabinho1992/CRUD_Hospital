using CRUDHospital.Data.Dtos.PacienteDto;
using CRUDHospital.Models;

namespace CRUDHospital.Repository.Interfaces
{
    public interface InterfacePaciente
    {
        ReadPacienteDtoId GetpacienteId(int id);
        void AddPaciente(CreatePacienteDto paciente);
        IEnumerable<ReadpacienteDto> GetPacientes();
        void UpdatePaciente(int id, UpdatePacienteDto pacienteDto);
        void DeletePaciente(int id);
    }
}
