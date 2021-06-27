using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Application.ViewModels
{
    public class MedicoViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoVielModel Endereco { get; set; }
        public string Crm { get; set; }
        public List<String> Especialidades { get; set; }

        public MedicoViewModel()
        {
        }

        public MedicoViewModel(string nome, string email, string telefone, string crm, List<string> especialidades, EnderecoVielModel endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Crm = crm;
            Especialidades = especialidades;
            Endereco = endereco;
        }
    }
}
