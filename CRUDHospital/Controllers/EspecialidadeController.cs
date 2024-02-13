using CRUDHospital.Data.Dtos.EspecialidadeDto;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDHospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EspecialidadeController : ControllerBase
    {
        private readonly IEspecialidadeRepository _context;

        public EspecialidadeController(IEspecialidadeRepository context)
        {
            _context = context;
        }

        [HttpPost("/Cadastrar_Especialidade")]
        public IActionResult AddEspecialidade(CreateEspecialidadeDto especialidadeDto)
        {
            _context.AddEspecialidade(especialidadeDto);
            return NoContent();
        }

        [HttpGet("/Lista_Especialidades")]
        public IActionResult GetEspecialidades()
        {
            return Ok(_context.GetEspecialidades());
        }

        [HttpGet("/Especialidade_Cadastrada")]
        public IActionResult GetEspecialidadeId(int id)
        {
            return Ok(_context.GetEspecialidadeId(id));
        }
    }
}
