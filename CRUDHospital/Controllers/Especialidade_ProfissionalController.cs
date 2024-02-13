using CRUDHospital.Data.Dtos.Especialidade_Profissional;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDHospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Especialidade_ProfissionalController : ControllerBase
    {
        private readonly IEspecialidadeProfissionalRepository _context;

        public Especialidade_ProfissionalController(IEspecialidadeProfissionalRepository context)
        {
            _context = context;
        }

        [HttpPost("/Cadastro_Especialidade_Profissional")]
        public IActionResult AddEspecialidadeProfissional(CreateEspecialidade_ProfissionalDto dto)
        {
            _context.Add(dto);
            return Ok("Adicionado com sucesso!");
        }

        [HttpGet("/Lista_Especialidades_profissionais")]
        public IActionResult GetEspecialidadesProfgissional()
        {
            return Ok(_context.Get());
        }
    }
}
