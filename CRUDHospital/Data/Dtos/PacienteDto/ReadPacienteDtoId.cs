using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Models;

namespace CRUDHospital.Data.Dtos.PacienteDto
{
    public class ReadPacienteDtoId
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Celular { get; set; }
        public virtual ICollection<ReadConsultaIdDto> ListaConsultas { get; set; }
    }
}
