using AutoMapper;
using CRUDHospital.Data;
using CRUDHospital.Data.Dtos.Especialidade_Profissional;

using CRUDHospital.Models;
using CRUDHospital.Repository.Interfaces;

namespace CRUDHospital.Repository
{
    public class EspecialidadeProfissionalRepository : IEspecialidadeProfissionalRepository
    {
        private readonly HospitalDbContext _context;
        private readonly IMapper _mapper;

        public EspecialidadeProfissionalRepository(HospitalDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(CreateEspecialidade_ProfissionalDto dto)
        {
            var add = _mapper.Map<EspecialidadeProfissionais>(dto);
            _context.EspecialidadeProfissionais.Add(add);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReadEspecialidade_ProfissionalDto> Get()
        {
            var resultado = _context.EspecialidadeProfissionais.ToList();
            return _mapper.Map<List<ReadEspecialidade_ProfissionalDto>>(resultado);
        }

        public void Update(int id, CreateEspecialidade_ProfissionalDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
