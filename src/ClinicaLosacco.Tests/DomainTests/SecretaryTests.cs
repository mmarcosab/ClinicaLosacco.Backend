

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
        public void criarHealthPlanFailWithNo()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Secretary secretary;
            Assert.Throws<ArgumentException>(() => secretary = new Secretary("Maria", "teste@teste.com.br", "13123456789", address));
        }

    }
}
