using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;

using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    
    public class AddressTests
    {
        [Fact]
        public void criarAddressSuccess()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            Assert.NotNull(address);
        }

        [Fact]
        public void criarAddressFailWithNoStreet() 
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarAddressFailWithNoNumber()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 0, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarAddressFailWithNoCity()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "", "SP", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarAddressFailWithNoState()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "", "01234567", "Brasil"));
        }
        
        [Fact]
        public void criarAddressFailWithNoPostCode()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "", "Brasil"));
        }
        [Fact]
        public void criarAddressFailWithNoCountry()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", ""));
        }


        [Fact]
        public void criarAddressFailWithNullStreet()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address(null, 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil"));
        }


        [Fact]
        public void criarAddressFailWithNullCity()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", null, "SP", "01234567", "Brasil"));
        }

        [Fact]
        public void criarAddressFailWithNullState()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", null, "01234567", "Brasil"));
        }

        [Fact]
        public void criarAddressFailWithNullPostCode()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", null, "Brasil"));
        }
        [Fact]
        public void criarAddressFailWithNullCountry()
        {
            Address address;
            Assert.Throws<Exception>(() => address = new Address("Rua de teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", null));
        }


    }
}
