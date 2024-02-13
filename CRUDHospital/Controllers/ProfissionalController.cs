using CRUDHospital.Data.Dtos.ProfissionalDto;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDHospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfissionalController : ControllerBase
    {
        private readonly IProfissionalRepository _context;

        public ProfissionalController(IProfissionalRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddPorissional(CreateProfissionalDto profissional)
        {
            _context.AddProfissional(profissional);
            return NoContent();
        }

        [HttpGet("/Lista_Profissionais")]
        public IActionResult GetProfissionais() 
        {
           return Ok (_context.GetProfissionais());
            
        }

        [HttpGet("/Profissional_Cadastrado")]
        public IActionResult GetProfissionalById(int id)
        {
            return Ok(_context.GetProfissionaisId(id));
        }

        [HttpPut("/Editar_Profissional")]
        public IActionResult updateProfissional(int id, UpdateProfissionalDto profissionalDto)
        {
            _context.UpdateProfissionais(id, profissionalDto);
            return NoContent();
        }

        [HttpDelete("/Delete_Profissional")]
        public IActionResult DeleteProfissional(int id)
        {
            _context.DeleteProfissionais(id);
            return NoContent();
        }
    }
}
