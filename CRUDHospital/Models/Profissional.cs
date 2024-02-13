using CRUDHospital.Models.Abstrata;
using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Models
{
    public class Profissional : Pessoa
    {
        
        public DateTime DataContratacao { get; set; }
        public virtual ICollection<Consulta> ListaConsultas { get; set; }
        public virtual ICollection<Especialidade> Especialidades { get; set; }


    }
}
