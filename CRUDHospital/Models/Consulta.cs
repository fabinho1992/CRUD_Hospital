using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Models
{
    public class Consulta
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double Preco {  get; set; }
        [Required]
        public DateTime DataConsulta { get; set; }
        public int PacienteId { get; set; }
        public virtual Paciente Paciente { get; set; }
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissional { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; } 

    }
}
