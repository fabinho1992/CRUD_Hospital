using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Data.Dtos.EspecialidadeDto;

namespace CRUDHospital.Data.Dtos.ProfissionalDto
{
    public class ReadProfissionalIdDto 
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Celular { get; set; }
        public DateTime DataContratacao { get; set; }
        public virtual ICollection<ReadConsultaDelahesProfissionalDto> ListaConsultas { get; set; }
        

    }
}
