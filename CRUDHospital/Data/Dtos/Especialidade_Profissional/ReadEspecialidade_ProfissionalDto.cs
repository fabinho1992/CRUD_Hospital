namespace CRUDHospital.Data.Dtos.Especialidade_Profissional
{
    public class ReadEspecialidade_ProfissionalDto
    {
        
        public string Profissional {  get; set; }
        public string Especialidade { get; set; }

        public override string ToString()
        {
            return $"Profissional: {Profissional} com especialidade {Especialidade}";
        }
    }
}
