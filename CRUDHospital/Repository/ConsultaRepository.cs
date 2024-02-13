using AutoMapper;
using CRUDHospital.Data;
using CRUDHospital.Data.Dtos.ConsultaDto;
using CRUDHospital.Models;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUDHospital.Repository
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly HospitalDbContext _context;
        private readonly IMapper _mapper;

        public ConsultaRepository(HospitalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddConsulta(CreateConsultaDto consultaDto)
        {
            var consulta = _mapper.Map<Consulta>(consultaDto);
            _context.Consultas.Add(consulta);
            _context.SaveChanges();
        }

        public void DeleteConsulta(int id)
        {
            var consulta = _context.Consultas.FirstOrDefault(c => c.Id == id);
            _context.Consultas.Remove(consulta);
            _context.SaveChanges();
        }

        public ReadConsultaIdDto GetConsultaId(int id)
        {
            var consulta = _context.Consultas.FirstOrDefault(c => c.Id == id);
            //if (consulta == null) throw new Exception("Consulta não encontrada!");
            return _mapper.Map<ReadConsultaIdDto>(consulta);
        }

        public IEnumerable<ReadConsultaDto> GetConsultas()
        {
            return _mapper.Map<List<ReadConsultaDto>>(_context.Consultas.ToList());
        }

        public void UpdateConsulta(int id, CreateConsultaDto pacienteDto)
        {
            var paciente = _context.Consultas.FirstOrDefault(c => c.Id == id);
            //if (paciente == null) throw new Exception("Consulta não encontrada!");
            _mapper.Map(pacienteDto, paciente);
            _context.SaveChanges();
        }
    }
}
