using System;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class FuncionarioTest
    {
        [Fact]
        public void criarFuncionarioComSuceso()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario = new Funcionario("Maria", "teste@teste.com.br", "123456789", endereco);
            Assert.NotNull(funcionario);
            Assert.Equal("Maria", funcionario.Nome);
            Assert.Equal("teste@teste.com.br", funcionario.Email);
            Assert.Equal("123456789", funcionario.Telefone);
            Assert.Equal(endereco, funcionario.Endereco);
        }

        [Fact]
        public void criarFuncionarioSemNome()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario("", "teste@teste.com.br", "123456789", endereco));
        }

        [Fact]
        public void criarFuncionarioSemEmail()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario("Maria", "", "123456789", endereco));
        }

        [Fact]
        public void criarFuncionarioSemTelefone()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario("Maria", "teste@teste.com.br", "", endereco));
        }

        [Fact]
        public void criarFuncionarioComNomeNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario(null, "teste@teste.com.br", "123456789", endereco));
        }

        [Fact]
        public void criarFuncionarioComEmailNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Core.Entities.Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario("Maria", null, "123456789", endereco));
        }

        [Fact]
        public void criarFuncionarioComTelefoneNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentException>(() => funcionario = new Funcionario("Maria", "teste@teste.com.br", null, endereco));
        }

        [Fact]
        public void criarFuncionarioComEnderecoNulo()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Funcionario funcionario;
            Assert.Throws<ArgumentNullException>(() => funcionario = new Funcionario("Maria", "teste@teste.com.br", "12345678974", null));
        }

    }
}
