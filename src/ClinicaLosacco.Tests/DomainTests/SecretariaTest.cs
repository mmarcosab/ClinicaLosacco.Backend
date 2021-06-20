

using ClinicaLosacco.Core.Entities;
using System;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class SecretariaTest
    {
        [Fact]
        public void criarSecretariaComSucesso()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria = new Secretaria("Maria", "teste@teste.com.br", "13123456789", endereco);
            Assert.NotNull(secretaria);
            Assert.Equal("Maria", secretaria.Nome);
            Assert.Equal("teste@teste.com.br", secretaria.Email);
            Assert.Equal("13123456789", secretaria.Telefone);
        }

        [Fact]
        public void criarSecretariaSemNome()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria("", "teste@teste.com.br", "13123456789", endereco));
        }

        [Fact]
        public void criarSecretariaSemEmail()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria("Maria", "", "13123456789", endereco));
        }

        [Fact]
        public void criarSecretariaSemTelefone()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria("Maria", "teste@teste.com.br", "", endereco));
        }

        [Fact]
        public void criarSecretariaComNomeNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria(null, "teste@teste.com.br", "13123456789", endereco));
        }

        [Fact]
        public void criarSecretariaComEmailNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria("Maria", null, "13123456789", endereco));
        }

        [Fact]
        public void criarSecretariaComTelefoneNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentException>(() => secretaria = new Secretaria("Maria", "teste@teste.com.br", null, endereco));
        }

        [Fact]
        public void criarSecretariaComEnderecoNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretaria secretaria;
            Assert.Throws<ArgumentNullException>(() => secretaria = new Secretaria("Maria", "teste@teste.com.br", "13123456789", null));
        }

    }
}
