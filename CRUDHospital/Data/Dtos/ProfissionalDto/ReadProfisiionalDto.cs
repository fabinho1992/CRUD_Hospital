namespace CRUDHospital.Data.Dtos.ProfissionalDto
{
    public class ReadProfisiionalDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public int Celular { get; set; }
        public DateTime DataContratacao { get; set; }
    }
}
