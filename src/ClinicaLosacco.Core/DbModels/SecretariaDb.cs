
namespace ClinicaLosacco.Core.DbModels
{
    public class SecretariaDb
    {
        public int SecretariaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoDb Endereco { get; set; }
        public SecretariaDb(string nome, string email, string telefone, EnderecoDb endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
