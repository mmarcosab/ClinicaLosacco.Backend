using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public Employee(string name, string email, string phoneNumber, Address address)
        {
            validarCampos(name, email, phoneNumber, address);
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        private void validarCampos(string name, string email, string phoneNumber, Address address)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("field" + nameof(name) + "must be filled");
            }
            if (String.IsNullOrEmpty(email))
            {
                throw new ArgumentException("field" + nameof(email) + "must be filled");
            }
            if (String.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("field" + nameof(phoneNumber) + "must be filled");
            }
            if (address == null)
            {
                throw new ArgumentNullException("field"+ nameof(address) + "number must be filled");
            }
        }

    }
}
