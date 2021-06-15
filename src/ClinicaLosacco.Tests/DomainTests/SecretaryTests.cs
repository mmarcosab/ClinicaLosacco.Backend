

using ClinicaLosacco.Core.Entities;
using System;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class SecretaryTests
    {
        [Fact]
        public void criarHealthPlanSuccess()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary = new Secretary("Maria", "teste@teste.com.br", "13123456789", address);
            Assert.NotNull(secretary);
            Assert.Equal("Maria", secretary.Name);
            Assert.Equal("teste@teste.com.br", secretary.Email);
            Assert.Equal("13123456789", secretary.PhoneNumber);
        }

        [Fact]
        public void criarHealthPlanFailWithNoName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("", "teste@teste.com.br", "13123456789", address));
        }

        [Fact]
        public void criarHealthPlanFailWithNoEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("Maria", "", "13123456789", address));
        }

        [Fact]
        public void criarHealthPlanFailWithNoPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("Maria", "teste@teste.com.br", "", address));
        }

        [Fact]
        public void criarHealthPlanFailWithNullName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary(null, "teste@teste.com.br", "13123456789", address));
        }

        [Fact]
        public void criarHealthPlanFailWithNullEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("Maria", null, "13123456789", address));
        }

        [Fact]
        public void criarHealthPlanFailWithNullPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("Maria", "teste@teste.com.br", null, address));
        }

        [Fact]
        public void criarHealthPlanFailWithNullAddress()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentNullException>(() => secretary = new Secretary("Maria", "teste@teste.com.br", "13123456789", null));
        }

    }
}
