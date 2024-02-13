using CRUDHospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDHospital.extensions
{
    public class EspecialidadeProfissionaisCofiguration : IEntityTypeConfiguration<EspecialidadeProfissionais>
    {
        public void Configure(EntityTypeBuilder<EspecialidadeProfissionais> builder)
        {
            builder.ToTable("_DbEspecialidadeProfissional");
            builder.HasOne(x => x.Especialidade).WithMany().HasForeignKey(x => x.EspecialidadeId);
            builder.HasOne(x => x.Profissional).WithMany().HasForeignKey(x => x.ProfissionalId);
            builder.HasKey(c => new { c.ProfissionalId, c.EspecialidadeId });

        }
    }
}
