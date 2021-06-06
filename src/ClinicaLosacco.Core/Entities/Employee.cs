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
        public Employee(string name, string email, string phoneNumber, Address _address)
        {
            validarCampos(name, email, phoneNumber, _address);
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = _address;
        }

        private void validarCampos(string _name, string _email, string _phoneNumber, Address _address)
        {
            if (_name == null || _name.Equals(""))
            {
                throw new Exception("field" + nameof(_name) + "must be filled");
            }
            if (_email == null || _email.Equals(""))
            {
                throw new Exception("field" + nameof(_email) + "must be filled");
            }
            if (_phoneNumber == null || _phoneNumber.Equals(""))
            {
                throw new Exception("field" + nameof(_phoneNumber) + "must be filled");
            }
            if (_address == null)
            {
                throw new Exception("field"+ nameof(_address) + "number must be filled");
            }
        }

    }
}
