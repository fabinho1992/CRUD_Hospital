using CRUDHospital.Data.Dtos.ProfissionalDto;

namespace CRUDHospital.Repository.Interfaces
{
    public interface IProfissionalRepository
    {
        void AddProfissional(CreateProfissionalDto profissionalDto);
        IEnumerable<ReadProfisiionalDto> GetProfissionais();
        ReadProfissionalIdDto GetProfissionaisId(int id);
        void UpdateProfissionais(int id, UpdateProfissionalDto profissionalDto);
        void DeleteProfissionais(int id);
    }
}
