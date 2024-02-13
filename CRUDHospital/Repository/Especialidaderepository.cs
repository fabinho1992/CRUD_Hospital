using AutoMapper;
using CRUDHospital.Data;
using CRUDHospital.Data.Dtos.EspecialidadeDto;
using CRUDHospital.Models;
using CRUDHospital.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUDHospital.Repository
{
    public class Especialidaderepository : IEspecialidadeRepository
    {
        private readonly HospitalDbContext _context;
        private readonly IMapper _mapper;

        public Especialidaderepository(HospitalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddEspecialidade(CreateEspecialidadeDto especialidadeDto)
        {
            var especialidade = _mapper.Map<Especialidade>(especialidadeDto);
            _context.Especialidades.Add(especialidade);
            _context.SaveChanges();
        }

        public void DeleteEspecialidade(int id)
        {
            var especialidade = _context.Especialidades.FirstOrDefault(e => e.Id == id);
            if (especialidade != null) _context.Especialidades.Remove(especialidade);
            _context.SaveChanges();
        }

        public ReadEspecialidadeIdDto GetEspecialidadeId(int id)
        {
            return _mapper.Map<ReadEspecialidadeIdDto>( _context.Especialidades.FirstOrDefault(e => e.Id == id));
        }

        public IEnumerable<ReadEspecialidadeDto> GetEspecialidades()
        {
            return _mapper.Map<List<ReadEspecialidadeDto>>(_context.Especialidades.ToList());
        }

        public void UpdateEspecialidade(int id, CreateEspecialidadeDto especialidadeDto)
        {
            var especialidade = _context.Especialidades.FirstOrDefault(e => e.Id == id);
            _mapper.Map(especialidadeDto, especialidade);
            _context.SaveChanges();
        }
    }
}
