
using CRUDHospital.Models.Abstrata;
using System.ComponentModel.DataAnnotations;

namespace CRUDHospital.Models
{
    public class Paciente : Pessoa
    {
        
        public DateTime DataNascimento { get; set; }
        public virtual ICollection<Consulta> ListaConsultas { get; set; }
           
    }
}
