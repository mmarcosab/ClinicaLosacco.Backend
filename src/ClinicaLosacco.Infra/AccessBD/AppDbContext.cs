using Microsoft.EntityFrameworkCore;
using ClinicaLosacco.Application.DbModels;

namespace ClinicaLosacco.Infra.AccessBD
{
    class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ConsultaDb> Consultas { get; set; }
        public DbSet<MedicoDb> Medicos { get; set; }
        public DbSet<SecretariaDb> Secretarias { get; set; }
        public DbSet<PacienteDb> Pacientes { get; set; }
        public DbSet<PlanoSaudeDb> PlanosSaude { get; set; }
        public DbSet<EnderecoDb> Enderecos { get; set; }
    }
}
