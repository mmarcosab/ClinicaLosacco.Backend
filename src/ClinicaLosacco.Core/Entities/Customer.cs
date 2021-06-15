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
       
        public Customer(string name, string cpf, int age, string email, string phone, Address address, HealthPlan healthPlan)
        {
            validarCampos(name, cpf, age, email, phone, address);
            Name = name;
            CPF = cpf;
            Age = age;
            Email = email;
            Phone = phone;
            Address = address;
            HealthPlan = healthPlan;
        }
        private void validarCampos(string name, string cpf, int age, string email, string phone, Address address)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("field " + nameof(name) + " must be filled");
            }
            if (String.IsNullOrEmpty(cpf))
            {
                throw new ArgumentException("field " + nameof(cpf) + " must be filled");
            }
            if (age.Equals(0))
            {
                throw new ArgumentException("field " + nameof(age) + " must be filled");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException("field " + nameof(email) + " must be filled");
            }
            if (String.IsNullOrEmpty(phone))
            {
                throw new ArgumentException("field " + nameof(phone) + " must be filled");
            }
            if (address == null)
            {
                throw new ArgumentNullException("field " + nameof(address) + " must be filled");
            }
        }

    }
}
