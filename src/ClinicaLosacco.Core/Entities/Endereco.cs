using System;

namespace ClinicaLosacco.Core.Entities
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set;}
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }


        public Endereco(string rua, int numero, string complemento, string cidade, string uf, string cep, string pais)
        {
            validarCampos(rua, numero, complemento, cidade, uf, cep, pais);
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            UF = uf;
            Cep = cep;
            Pais = pais;
        }

        private void validarCampos(string rua, int numero, string complemento, string cidade, string uf, string cep, string pais) 
        {
            if(String.IsNullOrEmpty(rua))
            {
                throw new ArgumentException("Campo " + nameof(rua) + " deve ser informado");
            }
            if (numero.Equals(0))
            {
                throw new ArgumentException("Campo " + nameof(numero) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(complemento))
            {
                throw new ArgumentException("Campo " + (nameof(complemento)) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(cidade))
            {
                throw new ArgumentException("Campo " + (nameof(cidade)) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(uf))
            {
                throw new ArgumentException("Campo " + (nameof(uf)) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(cep))
            {
                throw new ArgumentException("Campo " + (nameof(cep)) + " deve ser informado");
            }
            if (String.IsNullOrEmpty(pais))
            {
                throw new ArgumentException("Campo " + (nameof(pais)) + " deve ser informado");
            }
        }
    }

}