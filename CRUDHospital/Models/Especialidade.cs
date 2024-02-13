namespace CRUDHospital.Models
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Consulta> ListaConsultas { get; set; }
        public virtual ICollection<Profissional> Profissionais { get; set; }

    }
}
