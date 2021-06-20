using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Secretaria : Funcionario
    {       
        public Secretaria(string nome, string email, string telefone, Endereco endereco) : base(nome, email, telefone, endereco)
        {
     
        }
        public Consulta makeAnAppointment(Medico medico, Paciente paciente, DateTime dataConsulta)
        {
            return new Consulta(medico, paciente, dataConsulta);
        }
    }
}
