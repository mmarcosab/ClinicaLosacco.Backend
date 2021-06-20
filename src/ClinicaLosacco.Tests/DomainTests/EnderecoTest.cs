using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;

using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    
    public class EnderecoTest
    {
        [Fact]
        public void criarEnderecoComSucesso()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Assert.NotNull(endereco);
        }

        [Fact]
        public void criarEnderecoSemRua() 
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarEnderecoSemNumero()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 0, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarEnderecoSemCidade()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", "", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarEnderecoSemEstado()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarEnderecoSemCep()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "", "Brasil"));
        }
        [Fact]
        public void criarEnderecoSemPais()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", ""));
        }

        [Fact]
        public void criarEnderecoComRuaNula()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco(null, 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }


        [Fact]
        public void criarEnderecoComCidadeNula()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", null, "SP", "01234567", "Brasil"));
        }

        [Fact]
        public void criarEnderecoComUFNula()
        {
            Endereco endereco;
            Assert.Throws<ArgumentException>(() => endereco = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", null, "01234567", "Brasil"));
        }

        [Fact]
        public void criarAddressFailWithNullPostCode()
        {
            Endereco address;
            Assert.Throws<ArgumentException>(() => address = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", null, "Brasil"));
        }
        [Fact]
        public void criarAddressFailWithNullCountry()
        {
            Endereco address;
            Assert.Throws<ArgumentException>(() => address = new Endereco("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", null));
        }

        [Fact]
        public void criarAddressFailWithNullCcomplement()
        {
            Endereco address;
            Assert.Throws<ArgumentException>(() => address = new Endereco("Rua de teste", 250, null, "Sao Paulo", "SP", "01234567", "Brasil"));
        }

    }
}
