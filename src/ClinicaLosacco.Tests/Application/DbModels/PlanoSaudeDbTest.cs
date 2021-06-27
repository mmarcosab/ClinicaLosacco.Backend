using ClinicaLosacco.Application.DbModels;
using System;
using System.Collections.Generic;
using Xunit;

namespace ClinicaLosacco.Tests.Application.DbModels
{
    public class PlanoSaudeDbTest
    {

        [Fact]
        public void criarPlanoSaudeDbOk()
        {
            PlanoSaudeDb planoSaude = new PlanoSaudeDb("Sulamerica", "1254785478", "EX5");

            Assert.NotNull(planoSaude);
            Assert.Equal("Sulamerica", planoSaude.Nome);
            Assert.Equal("1254785478", planoSaude.NumeroRegistro);
            Assert.Equal("EX5", planoSaude.Tipo);
        }





    }
}
