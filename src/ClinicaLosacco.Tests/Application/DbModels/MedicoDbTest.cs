using ClinicaLosacco.Application.DbModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class MedicoDbTest
    {

        [Fact]
        public void criarMedicoDbOk()
        {
            EnderecoDb endereco = new EnderecoDb("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");

            MedicoDb medico = new MedicoDb("Maria", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);

            Assert.NotNull(medico);
            Assert.Equal("Maria", medico.Nome);
            Assert.Equal("teste@teste.com.br", medico.Email);
            Assert.Equal("123456789", medico.Telefone);
            Assert.Equal("2222222", medico.Crm);
            Assert.True(List<string>.Equals(especialidades, medico.Especialidades));
            Assert.Equal(endereco, medico.Endereco);
        }





    }
}
