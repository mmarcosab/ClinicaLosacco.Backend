
namespace ClinicaLosacco.Application.DbModels
{
    public class Secretaria
    {
        public int SecretariaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Secretaria(string nome, string email, string telefone, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
