using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Data.Dtos.PacienteDto
{
    public class CreatePacienteDto
    {
        
        public string Nome { get; set; }
        
        public string Cpf { get; set; }
        
        public DateTime DataNascimento { get; set; }
        public int Celular { get; set; }
    }
}
