using System;

namespace ClinicaLosacco.Core.Entities
{
    public class PlanoSaude
    {
        public string Nome { get; set; }
        public string NumeroRegistro { get; set; }
        public string Tipo { get; set;}

        public PlanoSaude(string nome, string numeroRegistro, string tipo)
        {
            validarCampos(nome, numeroRegistro, tipo);
            Nome = nome;
            NumeroRegistro = numeroRegistro;
            Tipo = tipo;
        }

        private void validarCampos(string nome, string numeroRegistro, string tipo)
        {
            if (String.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Campo " + nameof(nome) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(numeroRegistro))
            {
                throw new ArgumentException("Campo " + nameof(numeroRegistro) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(tipo))
            {
                throw new ArgumentException("Campo " + nameof(tipo) + " deve ser informado");
            }
        }
    }
}
