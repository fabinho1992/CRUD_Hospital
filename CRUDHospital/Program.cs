
using CRUDHospital.Data;
using CRUDHospital.Repository;
using CRUDHospital.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUDHospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling =
                                Newtonsoft.Json.ReferenceLoopHandling.Ignore);// adcionei o NewtonsoftHson para poder autualizar o banco usando o verbo PATCH

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //AddAutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Add Injeção de dependencia Repository
            builder.Services.AddTransient<InterfacePaciente, PacienteRepository>();
            builder.Services.AddTransient<IConsultaRepository, ConsultaRepository>();
            builder.Services.AddTransient<IProfissionalRepository, ProfissionalRepository>();
            builder.Services.AddTransient<IEspecialidadeRepository, Especialidaderepository>();
            builder.Services.AddTransient<IEspecialidadeProfissionalRepository, EspecialidadeProfissionalRepository>();

            //Add DbContext
            var connectionString = builder.Configuration.GetConnectionString("Conection");

            builder.Services.AddDbContext<HospitalDbContext>(opt => opt.UseLazyLoadingProxies().UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
