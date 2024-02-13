using CRUDHospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDHospital.extensions
{
    public class ConsultaConfiguration : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.HasOne(x => x.Profissional).WithMany(x => x.ListaConsultas).HasForeignKey(x => x.ProfissionalId);
        }
    }
}
