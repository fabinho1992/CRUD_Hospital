using CRUDHospital.Data.Dtos.PacienteDto;
using CRUDHospital.Data.Dtos.ProfissionalDto;

namespace CRUDHospital.Data.Dtos.ConsultaDto
{
    public class ReadConsultaIdDto
    {
        public int Id { get; set; }

        public double Preco { get; set; }

        public DateTime DataConsulta { get; set; }

        public string Paciente { get; set; }

        public string Profissional { get; set; }

        public string Especialidade { get; set; }
    }
}
