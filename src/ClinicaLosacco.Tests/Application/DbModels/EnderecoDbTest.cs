using ClinicaLosacco.Application.DbModels;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class EnderecoDbTest
    {

        [Fact]
        public void criarEnderecoDbOk()
        {
            EnderecoDb endereco = new EnderecoDb("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");

            Assert.NotNull(endereco);
            Assert.Equal("Rua de Teste", endereco.Rua);
            Assert.Equal(250, endereco.Numero);
            Assert.Equal("Apartamento 10", endereco.Complemento);
            Assert.Equal("Sao Paulo", endereco.Cidade);
            Assert.Equal("01234567", endereco.Cep);
            Assert.Equal("SP", endereco.UF);
            Assert.Equal("Brasil", endereco.Pais);
        }

    }
}
