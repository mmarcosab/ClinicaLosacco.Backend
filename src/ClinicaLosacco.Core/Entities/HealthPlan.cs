using System;

namespace ClinicaLosacco.Core.Entities
{
    public class HealthPlan
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Type { get; set;}

        public HealthPlan(string name, string registrationNumber, string type)
        {
            validarCampos(name, registrationNumber, type);
            Name = name;
            RegistrationNumber = registrationNumber;
            Type = type;
        }

        private void validarCampos(string name, string registrationNumber, string type)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("field " + nameof(name) + " must be filled");
            }
            if (String.IsNullOrEmpty(registrationNumber))
            {
                throw new ArgumentException("field " + nameof(registrationNumber) + " must be filled");
            }
            if (String.IsNullOrEmpty(type))
            {
                throw new ArgumentException("field " + nameof(type) + " must be filled");
            }
        }
    }
}
