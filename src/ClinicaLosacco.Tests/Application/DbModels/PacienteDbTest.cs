using ClinicaLosacco.Application.DbModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class PacienteDbTest
    {

        [Fact]
        public void criarPacienteDbOk()
        {
            EnderecoDb endereco = new EnderecoDb("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            DateTime dataNascimento = DateTime.Now;
            PlanoSaudeDb planoSaude = new PlanoSaudeDb("Sulamerica", "1254785478", "EX5");
            PacienteDb paciente = new PacienteDb("Joao", "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude);

            Assert.NotNull(paciente);
            Assert.Equal("Joao", paciente.Nome);
            Assert.Equal("12345678945", paciente.Cpf);
            Assert.Equal(dataNascimento, paciente.DataNascimento);
            Assert.Equal("teste@teste.com", paciente.Email);
            Assert.Equal("123456789", paciente.Telefone);
            Assert.Equal(endereco, paciente.Endereco);
            Assert.Equal(planoSaude, paciente.PlanoSaude);
        }





    }
}
