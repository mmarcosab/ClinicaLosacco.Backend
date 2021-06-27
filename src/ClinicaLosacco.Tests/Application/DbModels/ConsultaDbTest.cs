using ClinicaLosacco.Application.DbModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class ConsultaDbTest
    {

        [Fact]
        public void criarConsultaDbOk()
        {
            EnderecoDb endereco = new EnderecoDb("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");

            MedicoDb medico = new MedicoDb("Maria", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);

            DateTime dataNascimento = DateTime.Now;

            PlanoSaudeDb planoSaude = new PlanoSaudeDb("Sulamerica", "1254785478", "EX5");
            PacienteDb paciente = new PacienteDb("Joao", "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude);

            DateTime dataCansulta = new DateTime();

            ConsultaDb consulta = new ConsultaDb(medico, paciente, dataCansulta);

            Assert.NotNull(consulta);
            Assert.Equal(medico, consulta.Medico);
            Assert.Equal(paciente, consulta.Paciente);
            Assert.Equal(dataCansulta, consulta.Data);
        }





    }
}
