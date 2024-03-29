﻿using System;

namespace ClinicaLosacco.Core.DbModels
{
    public class EnderecoDb
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set;}
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }


        public EnderecoDb(string rua, int numero, string complemento, string cidade, string uf, string cep, string pais)
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