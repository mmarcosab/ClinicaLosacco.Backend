using System;
using System.Collections.Generic;

namespace ClinicaLosacco.Application.DbModels
{
    public class MedicoDb
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnderecoDb Endereco { get; set; }
        public string Crm { get; set; }
        public List<String> Especialidades { get; set; }

        public MedicoDb(string nome, string email, string telefone, string crm, List<string> especialidades, EnderecoDb endereco)
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
