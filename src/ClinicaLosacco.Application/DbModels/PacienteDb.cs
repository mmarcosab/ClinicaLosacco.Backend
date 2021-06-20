using System;


namespace ClinicaLosacco.Application.DbModels
{
    public class PacienteDb
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoDb Endereco { get; set; }
        public PlanoSaudeDb PlanoSaude { get; set; }
       
        public PacienteDb(string nome, string cpf, DateTime dataNascimento, string email, string telefone, EnderecoDb endereco, PlanoSaudeDb planoSaude)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            PlanoSaude = planoSaude;
        }

    }
}
