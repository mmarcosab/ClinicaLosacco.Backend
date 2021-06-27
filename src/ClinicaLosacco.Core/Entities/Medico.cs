using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    /// <summary>
    /// This class define a doctor of Clinica Losacco
    /// </summary>
    public class Medico : Funcionario
    {
        public string Crm { get; set; }
        public List<String> Especialidades { get; set; }

        public Medico(string nome, string email, string telefone, string crm, List<string> especialidades, Endereco endereco) : base(nome, email, telefone, endereco)
        {
            validarCampos(crm, especialidades);
            Crm = crm;
            Especialidades = especialidades;
        }

        public void validarCampos(string crm, List<string> especialidades)
        {
            if (String.IsNullOrEmpty(crm))
            {
                throw new ArgumentException("Campo " + nameof(crm) + " deve ser informado");
            }
            if (especialidades == null || especialidades.Count.Equals(0))
            {
                throw new ArgumentException("Campo " + nameof(especialidades) + " deve ser informado");
            }
        }
    }
}
