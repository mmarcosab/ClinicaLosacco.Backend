using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Application.ViewModels
{
    public class EnderecoVielModel
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }


        public EnderecoVielModel(string rua, int numero, string complemento, string cidade, string uf, string cep, string pais)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            UF = uf;
            Cep = cep;
            Pais = pais;
        }
    }
}
