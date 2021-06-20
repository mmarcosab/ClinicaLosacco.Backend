using System;


namespace ClinicaLosacco.Application.DbModels
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public PlanoSaude PlanoSaude { get; set; }
       
        public Paciente(string nome, string cpf, DateTime dataNascimento, string email, string telefone, Endereco endereco, PlanoSaude planoSaude)
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
