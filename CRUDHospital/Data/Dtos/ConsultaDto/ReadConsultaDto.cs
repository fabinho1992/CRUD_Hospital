using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Data.Dtos.ConsultaDto
{
    public class ReadConsultaDto
    {
        
        public int Id { get; set; }
        
        public double Preco { get; set; }
        
        public DateTime DataConsulta { get; set; }

        public int PacienteId { get; set; }

    }
}
