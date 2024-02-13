using AutoMapper;
using CRUDHospital.Data;
using CRUDHospital.Data.Dtos.PacienteDto;
using CRUDHospital.Models;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CRUDHospital.Repository;

public class PacienteRepository : InterfacePaciente
{
    private readonly HospitalDbContext _context;
    private readonly IMapper _mapper;

    public PacienteRepository(HospitalDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void AddPaciente(CreatePacienteDto pacienteDto)
    {
        var paciente = _mapper.Map<Paciente>(pacienteDto);
        _context.Pacientes.Add(paciente);
        _context.SaveChanges();
    }

    public void DeletePaciente(int id)
    {
        var paciente = _context.Pacientes.FirstOrDefault(p => p.Id == id);
        if (paciente != null) 
        _context.Pacientes.Remove(paciente);
        _context.SaveChanges();
    }

    public ReadPacienteDtoId GetpacienteId(int id)
    {
       return _mapper.Map<ReadPacienteDtoId>(_context.Pacientes.Include(x => x.ListaConsultas)
           .FirstOrDefault(p => p.Id == id));
    
    }

    public IEnumerable<ReadpacienteDto> GetPacientes()
    {
       return _mapper.Map<List<ReadpacienteDto>>(_context.Pacientes.ToList());
    
    }

    public void UpdatePaciente(int id, UpdatePacienteDto pacienteDto)
    {
        var paciente = _context.Pacientes.FirstOrDefault(p => p.Id == id);
        _mapper.Map(pacienteDto, paciente);
        _context.SaveChanges();
    }
}
