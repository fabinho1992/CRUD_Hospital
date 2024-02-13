namespace CRUDHospital.Data.Dtos.ProfissionalDto
{
    public class CreateProfissionalDto
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Celular { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
