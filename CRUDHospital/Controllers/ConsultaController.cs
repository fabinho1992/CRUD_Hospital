using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDHospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaRepository _context;

        public ConsultaController(IConsultaRepository context)
        {
            _context = context;
        }

        [HttpPost("/Cadastrar_Consulta")]
        public IActionResult CadastroConsultas(CreateConsultaDto consultaDto)
        {
            _context.AddConsulta(consultaDto);
            return NoContent();
        }

        [HttpGet("/Lista_Consultas")]
        public IActionResult GetConsultas()
        {
            return Ok(_context.GetConsultas());
        }

        [HttpGet("/Consulta_Cadastrada")]
        public IActionResult GetConsultaId(int id)
        {
            return Ok(_context.GetConsultaId(id));
        }

        [HttpPut("/Editar_Consulta")]
        public IActionResult UpdateConsulta(int id, CreateConsultaDto consultaDto)
        {
            _context.UpdateConsulta(id, consultaDto);
            return NoContent();
        }

        [HttpDelete("/Deletar_Consulta")]
        public IActionResult DeleteConsulta(int id)
        {
            _context.DeleteConsulta(id);
            return NoContent();
        }
    }
}
