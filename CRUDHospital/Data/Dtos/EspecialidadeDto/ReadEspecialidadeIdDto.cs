using CRUDHospital.Models;

namespace CRUDHospital.Data.Dtos.EspecialidadeDto
{
    public class ReadEspecialidadeIdDto
    {
        public string Nome { get; set; }
        public virtual ICollection<ReadEspecialidadeDto> Profissionais { get; set; }

    }
}
