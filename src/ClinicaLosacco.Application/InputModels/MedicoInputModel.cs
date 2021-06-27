using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Application.InputModels
{
    public class MedicoInputModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoInputModel Endereco { get; set; }
        public string Crm { get; set; }
        public List<String> Especialidades { get; set; }
        public MedicoInputModel()
        {
        }
        public MedicoInputModel(string nome, string email, string telefone, string crm, List<string> especialidades, EnderecoInputModel endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Crm = crm;
            Especialidades = especialidades;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
