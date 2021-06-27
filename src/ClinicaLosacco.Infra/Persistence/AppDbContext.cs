using ClinicaLosacco.Core.DbModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ClinicaLosacco.Infra.Persistencia
{
    [ExcludeFromCodeCoverage]
    public class AppDbContext : DbContext   //DBContext serve para usar o entity framework
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
