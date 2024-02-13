using AutoMapper;
using CRUDHospital.Data;
using CRUDHospital.Data.Dtos.ProfissionalDto;
using CRUDHospital.Models;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUDHospital.Repository
{
    public class ProfissionalRepository : IProfissionalRepository
    {
        private readonly HospitalDbContext _context;
        private readonly IMapper _mapper;

        public ProfissionalRepository(HospitalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddProfissional(CreateProfissionalDto profissionalDto)
        {
            var profissional = _mapper.Map<Profissional>(profissionalDto);
            _context.Profissionais.Add(profissional);
            _context.SaveChanges();
        }

        public void DeleteProfissionais(int id)
        {
            var paciente = _context.Profissionais.FirstOrDefault(p => p.Id == id);
            if (paciente != null) _context.Profissionais.Remove(paciente);
            _context.SaveChanges();
        }

        public IEnumerable<ReadProfisiionalDto> GetProfissionais()
        {
            return _mapper.Map<List<ReadProfisiionalDto>>(_context.Profissionais.ToList());
        }

        public ReadProfissionalIdDto GetProfissionaisId(int id)
        {
            return _mapper.Map<ReadProfissionalIdDto>(_context.Profissionais.FirstOrDefault(p => p.Id == id));
        }

        public void UpdateProfissionais(int id, UpdateProfissionalDto profissionalDto)
        {
            var profissional = _context.Profissionais.FirstOrDefault(p => p.Id == id);
            _mapper.Map(profissionalDto, profissional);
            _context.SaveChanges();
        }
    }
}
