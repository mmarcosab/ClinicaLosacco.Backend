using System;
using System.Collections.Generic;
using System.Text;
using ClinicaLosacco.Core.Entities;
using Xunit;

namespace ClinicaLosacco.Tests.DomainTests
{
    public class HealthPlanTests
    {
        [Fact]
        public void criarHealthPlanSuccess()
        {
            HealthPlan healthPlan = new HealthPlan("Sulamerica", "1254785478", "EX5");
            Assert.NotNull(healthPlan);
            Assert.Equal("Sulamerica", healthPlan.Name);
            Assert.Equal("1254785478", healthPlan.RegistrationNumber);
            Assert.Equal("EX5", healthPlan.Type);
        }

        [Fact]
        public void criarHealthPlanFailWithNoName()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan("", "1254785478", "EX5"));
        }

        [Fact]
        public void criarHealthPlanFailWithNoReggistrationNumber()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan("Sulamerica", "", "EX5"));
        }

        [Fact]
        public void criarHealthPlanFailWithNoType()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan("Sulamerica", "1254785478", ""));
        }

        [Fact]
        public void criarHealthPlanFailWithNullName()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan(null, "1254785478", "EX5"));
        }

        [Fact]
        public void criarHealthPlanFailWithNullReggistrationNumber()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan("Sulamerica", null, "EX5"));
        }

        [Fact]
        public void criarHealthPlanFailWithNullType()
        {
            HealthPlan healthPlan;
            Assert.Throws<Exception>(() => healthPlan = new HealthPlan("Sulamerica", "1254785478", null));
        }
    }
}

