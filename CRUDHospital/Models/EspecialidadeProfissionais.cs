namespace CRUDHospital.Models
{
    public class EspecialidadeProfissionais
    {
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissional { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}
