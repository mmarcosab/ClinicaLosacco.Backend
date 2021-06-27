using ClinicaLosacco.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace ClinicaLosacco.Tests.DomainTests
{
    public class ConsultaTest
    {
        [Fact]
        public void criarConsultaComSucesso()
        {
            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");

            Medico medico = new Medico("Maria", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);

            DateTime dataNascimento = DateTime.Now;

            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente = new Paciente("Joao", "12345678945", dataNascimento, "teste@teste.com", "123456789", endereco, planoSaude);

            DateTime dataCansulta = new DateTime();

            Consulta consulta = new Consulta(medico, paciente, dataCansulta);

            Assert.NotNull(consulta);
            Assert.Equal(medico, consulta.Medico);
            Assert.Equal("teste@teste.com.br", medico.Email);
            Assert.Equal("123456789", medico.Telefone);
            Assert.Equal("2222222", medico.Crm);
            Assert.Equal(especialidades, medico.Especialidades);
            Assert.Equal(endereco, medico.Endereco);

        }

        [Fact]
        public void criarConsultaSemMedico()
        {
            DateTime data = new DateTime();

            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            
            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");
            Medico medico = new Medico("Teste", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);

            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente = new Paciente("Joao", "12345678945", data, "teste@teste.com", "123456789", endereco, planoSaude);
            
            Consulta consulta;
            
            Assert.Throws<ArgumentNullException>(() => consulta = new Consulta(null, paciente, data));
        }

        [Fact]
        public void criarConsultaSemPaciente()
        {
            DateTime data = new DateTime();

            Endereco endereco = new Endereco("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");

            List<string> especialidades = new List<string>();
            especialidades.Add("cardiologista");
            Medico medico = new Medico("Teste", "teste@teste.com.br", "123456789", "2222222", especialidades, endereco);

            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Paciente paciente = new Paciente("Joao", "12345678945", data, "teste@teste.com", "123456789", endereco, planoSaude);

            Consulta consulta;

            Assert.Throws<ArgumentNullException>(() => consulta = new Consulta(medico, null, data));
        }

    }
}

