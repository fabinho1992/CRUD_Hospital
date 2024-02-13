using AutoMapper;
using CRUDHospital.Data.Dtos.PacienteDto;
using CRUDHospital.Models;
using CRUDHospital.Repository;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CRUDHospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly InterfacePaciente _context;

        public PacienteController(InterfacePaciente context)
        {
            _context = context;

        }

        [HttpPost("/Cadastrar_Paciente")]
        public IActionResult AddPaciente(CreatePacienteDto pacienteDto)
        {

            _context.AddPaciente(pacienteDto);
            return NoContent();
        }

        [HttpGet("/Lista_Pacientes")]
        public IActionResult GetPacientes()
        {
            var paciente = _context.GetPacientes();
            return Ok(paciente);
        }

        [HttpGet("/Paciente_Cadastrado")]
        public IActionResult GetPacienteId(int id)
        {
            var paciente = _context.GetpacienteId(id);
            return Ok(paciente);
        }

        [HttpPut("/Editar_Paciente")]
        public IActionResult UpdatePaciente(int id, UpdatePacienteDto pacienteDto)
        {
            _context.UpdatePaciente(id, pacienteDto);
            return NoContent();

        }

        [HttpDelete("/Delete_Paciente")]
        public IActionResult DeletePaciente(int id)
        {
            _context.DeletePaciente(id);
            return NoContent();
        }

    }
}
