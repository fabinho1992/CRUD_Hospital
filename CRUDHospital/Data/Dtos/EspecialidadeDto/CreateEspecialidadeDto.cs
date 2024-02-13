using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Data.Dtos.EspecialidadeDto
{
    public class CreateEspecialidadeDto
    {
        [Required]
        public string Nome { get; set; }
    }
}
