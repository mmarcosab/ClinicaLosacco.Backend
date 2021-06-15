using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class DoctorTests
    {
        [Fact]
        public void criarDoctorWithSuccess()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor = new Doctor("Maria", "teste@teste.com.br", "123456789", "2222222", specialts, address);
            Assert.NotNull(doctor);
            Assert.Equal("Maria", doctor.Name);
            Assert.Equal("teste@teste.com.br", doctor.Email);
            Assert.Equal("123456789", doctor.PhoneNumber);
            Assert.Equal("2222222", doctor.Crm);
            Assert.Equal(specialts, doctor.Specialties);
            Assert.Equal(address, doctor.Address);
        }

        [Fact]
        public void criarDoctorFailWithNoName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("", "teste@teste.com.br", "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNoEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", "", "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNoPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", "teste@teste.com.br", "", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithSpecialtiesEmpty()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", "teste@teste.com.br", "12345678998", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullName()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor(null, "teste@teste.com.br", "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullEmail()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", null, "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullPhoneNumber()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", "teste@teste.com.br", null, "2222222", specialts, address));
        }


        [Fact]
        public void criarDoctorFailWithSpecialtiesNull()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Doctor("Maria", "teste@teste.com.br", "12345678998", "2222222", null, address));
        }

        [Fact]
        public void criarDoctorFailWithAdressNull()
        {
            Address address = new Address("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Doctor doctor;
            Assert.Throws<ArgumentNullException>(() => doctor = new Doctor("Maria", "teste@teste.com.br", "12345678998", "2222222", specialts, null));
        }
    }
}

