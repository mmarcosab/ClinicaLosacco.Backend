using System;
using System.Collections.Generic;

namespace ClinicaLosacco.Application.DbModels
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public string Crm { get; set; }
        public List<String> Especialidades { get; set; }

        public Medico(string nome, string email, string telefone, string crm, List<string> especialidades, Endereco endereco)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Crm = crm;
            Especialidades = especialidades;
        }

    }
}
