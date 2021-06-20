using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class MedicoTest
    {
        [Fact]
        public void criarMedicoComSucesso()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");
            Medico medico = new Medico("Maria", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);
            Assert.NotNull(medico);
            Assert.Equal("Maria", medico.Nome);
            Assert.Equal("teste@teste.com.br", medico.Email);
            Assert.Equal("123456789", medico.Telefone);
            Assert.Equal("2222222", medico.Crm);
            Assert.Equal(especialidades, medico.Especialidades);
            Assert.Equal(endereco, medico.Endereco);
        }

        [Fact]
        public void criarMedicoSemNome()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");
            Medico medico;
            Assert.Throws<ArgumentException>(() => medico = new Medico("", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco));
        }

        [Fact]
        public void criarmedicoSemEmail()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");
            Medico medico;
            Assert.Throws<ArgumentException>(() => medico = new Medico("Maria", "", "123456789", "2222222", especialidades, endereco));
        }

        [Fact]
        public void criarMedicoSemTelefone()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico("Maria", "teste@teste.com.br", "", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithSpecialtiesEmpty()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico("Maria", "teste@teste.com.br", "12345678998", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullName()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico(null, "teste@teste.com.br", "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullEmail()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico("Maria", null, "123456789", "2222222", specialts, address));
        }

        [Fact]
        public void criarDoctorFailWithNullPhoneNumber()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico("Maria", "teste@teste.com.br", null, "2222222", specialts, address));
        }


        [Fact]
        public void criarDoctorFailWithSpecialtiesNull()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentException>(() => doctor = new Medico("Maria", "teste@teste.com.br", "12345678998", "2222222", null, address));
        }

        [Fact]
        public void criarDoctorFailWithAdressNull()
        {
            Endereco address = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            Medico doctor;
            Assert.Throws<ArgumentNullException>(() => doctor = new Medico("Maria", "teste@teste.com.br", "12345678998", "2222222", specialts, null));
        }
    }
}

