using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class HealthPlan
    {
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Type { get; set;}

        public HealthPlan(string _name, string _registrationNumber, string _type)
        {
            validarCampos(_name, _registrationNumber, _type);
            Name = _name;
            RegistrationNumber = _registrationNumber;
            Type = _type;
        }

        private void validarCampos(string _name, string _registrationNumber, string _type)
        {
            if (_name == null || _name.Equals(""))
            {
                throw new Exception("field name must be filled");
            }
            if (_registrationNumber == null || _registrationNumber.Equals(""))
            {
                throw new Exception("field registration number must be filled");
            }
            if (_type == null || _type.Equals(""))
            {
                throw new Exception("field type must be filled");
            }
        }
    }
}
