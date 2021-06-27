using ClinicaLosacco.Application.DbModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class SecretariaDbTest
    {

        [Fact]
        public void criarSecretariaDbOk()
        {
            EnderecoDb endereco = new EnderecoDb("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            SecretariaDb secretaria = new SecretariaDb("Maria", "teste@teste.com.br", "123456789", endereco);

            Assert.NotNull(secretaria);
            Assert.Equal("Maria", secretaria.Nome);
            Assert.Equal("teste@teste.com.br", secretaria.Email);
            Assert.Equal("123456789", secretaria.Telefone);
            Assert.Equal(endereco, secretaria.Endereco);

        }





    }
}
