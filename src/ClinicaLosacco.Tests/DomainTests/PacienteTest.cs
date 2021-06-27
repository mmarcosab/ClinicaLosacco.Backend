using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class PacienteTest
    {
        [Fact]
        public void criarPacienteComsucesso()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente = new Paciente("Joao", "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude);
            Assert.NotNull(paciente);
            Assert.Equal(endereco, paciente.Endereco);
        }

        [Fact]
        public void criarPacienteSemNome()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("", "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteSemCpf()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", "", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude));
        }

        [Fact]
        public void criarEnderecoSemEmail()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, "", "123456789", endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteSemTelefone()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, "teste@teste.com", "", endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteComNomeNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente(null, "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteComCpfNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", null, dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude));
        }


        [Fact]
        public void criarPacienteComEmailNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, null, "123456789", endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteComTelefoneNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, "teste@teste.com", null, endereco, planoSaude));
        }

        [Fact]
        public void criarPacienteComEnderecoNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentNullException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, "teste@teste.com", "123456789", null, planoSaude));
        }

        [Fact]
        public void criarEnderecoComPlanoSaudeNulo()
        {
            DateTime dataNascimento = DateTime.Now;
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente;
            Assert.Throws<ArgumentNullException>(() => paciente = new Paciente("Jose", "12345678965", dataNascimento, "teste@teste.com", "123456789", endereco, null));
        }
    }

}

