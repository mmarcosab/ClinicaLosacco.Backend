using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public PlanoSaude PlanoSaude { get; set; }
       
        public Paciente(string nome, string cpf, DateTime dataNascimento, string email, string telefone, Endereco endereco, PlanoSaude planoSaude)
        {
            validarCampos(nome, cpf, dataNascimento, email, telefone, endereco, planoSaude);
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            PlanoSaude = planoSaude;
        }
        private void validarCampos(string nome, string cpf, DateTime dataNascimento, string email, string telefone, Endereco endereco, PlanoSaude planoSaude)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Campo " + nameof(nome) + " deve ser preenchido");
            }
            if (String.IsNullOrEmpty(cpf))
            {
                throw new ArgumentException("Campo " + nameof(cpf) + " deve ser preenchido");
            }
            if (dataNascimento == null)
            {
                throw new ArgumentException("Campo " + nameof(dataNascimento) + " deve ser preenchido");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Campo " + nameof(email) + " deve ser preenchido");
            }
            if (String.IsNullOrEmpty(telefone))
            {
                throw new ArgumentException("Campo " + nameof(telefone) + " deve ser preenchido");
            }
            if (endereco == null)
            {
                throw new ArgumentNullException("Campo " + nameof(endereco) + " deve ser preenchido");
            }
            if (planoSaude == null)
            {
                throw new ArgumentNullException("Campo " + nameof(planoSaude) + " deve ser preenchido");
            }
        }

    }
}
