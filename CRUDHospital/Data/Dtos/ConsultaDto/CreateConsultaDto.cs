using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Data.Dtos.ConsultaDto
{
    public class CreateConsultaDto
    {
        [Required]
        public double Preco { get; set; }
        [Required]
        public DateTime DataConsulta { get; set; }
        [Required]
        public int PacienteId { get; set; }
        [Required]
        public int ProfissionalId { get; set; }
        [Required]
        public int EspecialidadeId { get; set; }
    }
}
