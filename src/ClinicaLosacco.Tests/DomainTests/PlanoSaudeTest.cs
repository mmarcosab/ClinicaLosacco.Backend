using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class PlanoSaudeTest
    {
        [Fact]
        public void criarPlanoSaudeComSucesso()
        {
            PlanoSaude planoSaude = new PlanoSaude("Sulamerica", "1254785478", "EX5");
            Assert.NotNull(planoSaude);
            Assert.Equal("Sulamerica", planoSaude.Nome);
            Assert.Equal("1254785478", planoSaude.NumeroRegistro);
            Assert.Equal("EX5", planoSaude.Tipo);
        }

        [Fact]
        public void criarPlanoSaudeSemNome()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude("", "1254785478", "EX5"));
        }

        [Fact]
        public void criarPlanoSaudeSemNumeroRegistro()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude("Sulamerica", "", "EX5"));
        }

        [Fact]
        public void criarPlanoSaudeSemTipo()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude("Sulamerica", "1254785478", ""));
        }

        [Fact]
        public void criarPlanoSaudeComNomeNulo()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude(null, "1254785478", "EX5"));
        }

        [Fact]
        public void criarPlanoSaudeComNumeroRegistroNulo()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude("Sulamerica", null, "EX5"));
        }

        [Fact]
        public void criarPlanoSaudeComTipoNulo()
        {
            PlanoSaude planoSaude;
            Assert.Throws<ArgumentException>(() => planoSaude = new PlanoSaude("Sulamerica", "1254785478", null));
        }

    }
}

