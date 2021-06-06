using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public HealthPlan HealthPlan { get; set; }
       
        public Customer(string _name, string _cpf, int _age, string _email, string _phone, Address _address, HealthPlan _healthPlan)
        {
            validarCampos(_name, _cpf, _age, _email, _phone, _address);
            Name = _name;
            CPF = _cpf;
            Age = _age;
            Email = _email;
            Phone = _phone;
            Address = _address;
            HealthPlan = _healthPlan;
        }
        private void validarCampos(string _name, string _cpf, int _age, string _email, string _phone, Address _address)
        {
            if (_name == null || _name.Equals(""))
            {
                throw new Exception("field name must be filled ");
            }
            if (_cpf == null || _cpf.Equals(""))
            {
                throw new Exception("field cpf must be filled ");
            }
            if (_age.Equals(0))
            {
                throw new Exception("field age must be filled ");
            }
            if (_email == null || _email.Equals(""))
            {
                throw new Exception("field email must be filled ");
            }
            if (_phone == null || _phone.Equals(""))
            {
                throw new Exception("field phone must be filled ");
            }
            if (_address == null)
            {
                throw new Exception("address must be filled ");
            }
        }

    }
}
