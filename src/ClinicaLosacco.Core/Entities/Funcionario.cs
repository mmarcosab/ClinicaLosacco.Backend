using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public Funcionario(string nome, string email, string telefone, Endereco endereco)
        {
            validarCampos(nome, email, telefone, endereco);
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        private void validarCampos(string nome, string email, string telefone, Endereco endereco)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Campo " + nameof(nome) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Campo " + nameof(email) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(telefone))
            {
                throw new ArgumentException("Campo " + nameof(telefone) + " deve ser informado");
            }
            if (endereco == null)
            {
                throw new ArgumentNullException("Campo " + nameof(endereco) + " deve ser informado");
            }
        }

    }
}
