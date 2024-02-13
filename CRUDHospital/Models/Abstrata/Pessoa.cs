using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Models.Abstrata
{
    public abstract class Pessoa
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public int Celular { get; set; }

    }
}
