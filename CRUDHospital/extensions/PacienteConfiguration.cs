using CRUDHospital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDHospital.extensions
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Db_Pacientes");

            builder.Property(x => x.Id).IsRequired();

            builder.Property(a => a.Nome).HasColumnType("varchar(50)").IsRequired();

            builder.Property(a => a.Cpf).HasColumnType("varchar(11)").IsRequired();

            builder.Property(a => a.DataNascimento).IsRequired();
        }
    }
}
