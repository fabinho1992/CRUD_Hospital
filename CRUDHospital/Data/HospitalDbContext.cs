using CRUDHospital.extensions;
using CRUDHospital.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDHospital.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration(new ConsultaConfiguration());
            modelBuilder.ApplyConfiguration(new ProfissionalConfiguration());
            modelBuilder.ApplyConfiguration(new EspecialidadeProfissionaisCofiguration());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<EspecialidadeProfissionais> EspecialidadeProfissionais { get; set; }

    }
}
