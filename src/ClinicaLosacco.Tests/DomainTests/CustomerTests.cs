using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class CustomerTests
    {
        [Fact]
        public void criarCustomerSuccess()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer = new Customer("Joao", "12345678945", 18, "teste@teste.com", "123456789", address, healthPlan);
            Assert.NotNull(customer);
            Assert.Equal(address, customer.Address);
        }

        [Fact]
        public void criarCustomerFailWithNoName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("", "12345678945", 18, "teste@teste.com", "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNoCpf()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "", 18, "teste@teste.com", "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNoAge()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 0, "teste@teste.com", "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNoEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 0, "", "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNoPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 20, "teste@teste.com", "", address, healthPlan));
        }

        [Fact]
        public void criarCustomerFailWithNullName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer(null, "12345678945", 18, "teste@teste.com", "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNullCpf()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", null, 18, "teste@teste.com", "123456789", address, healthPlan));
        }


        [Fact]
        public void criarAddressFailWithNullEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 0, null, "123456789", address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNullPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 20, "teste@teste.com", null, address, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNullAddress()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 0, "teste@teste.com", "123456789", null, healthPlan));
        }

        [Fact]
        public void criarAddressFailWithNullHealthPlan()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Customer customer;
            Assert.Throws<Exception>(() => customer = new Customer("Jose", "12345678965", 0, "teste@teste.com", "123456789", address, null));
        }

    }
}

