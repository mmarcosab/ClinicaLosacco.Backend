using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class EmployeeTests
    {
        [Fact]
        public void criarEmployeeWithSuccess()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee = new Employee("Maria", "teste@teste.com.br", "123456789", address);
            Assert.NotNull(employee);
            Assert.Equal("Maria", employee.Name);
            Assert.Equal("teste@teste.com.br", employee.Email);
            Assert.Equal("123456789", employee.PhoneNumber);
            Assert.Equal(address, employee.Address);
        }

        [Fact]
        public void criarEmployeeFailWithNoName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("", "teste@teste.com.br", "123456789", address));
        }

        [Fact]
        public void criarEmmployeeFailWithNoEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("Maria", "", "123456789", address));
        }

        [Fact]
        public void criarEmployeeFailWithNoPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("Maria", "teste@teste.com.br", "", address));
        }

        [Fact]
        public void criarEmployeeFailWithNullName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee(null, "teste@teste.com.br", "123456789", address));
        }

        [Fact]
        public void criarEmmployeeFailWithNullEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("Maria", null, "123456789", address));
        }

        [Fact]
        public void criarEmployeeFailWithNullPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("Maria", "teste@teste.com.br", null, address));
        }
        [Fact]
        public void criarEmployeeFailWithNullAddress()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Employee employee;
            Assert.Throws<Exception>(() => employee = new Employee("Maria", "teste@teste.com.br", "12345678974", null));
        }
    }
}

