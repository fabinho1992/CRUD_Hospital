namespace CRUDHospital.Data.Dtos.ConsultaDto
{
    public class ReadConsultaDelahesProfissionalDto
    {
        public int Id { get; set; }

        public double Preco { get; set; }

        public DateTime DataConsulta { get; set; }

        public string Paciente { get; set; }
    }
}
