using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Address
    {
        public string Street { get; set; }
        public int Number { get; set;}
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


        public Address(string _street, int _number, string _complement, string _city, string _state, string _postalCode, string _country)
        {
            validarCampos(_street, _number, _complement, _city, _state, _postalCode, _country);
            Street = _street;
            Number = _number;
            Complement = _complement;
            City = _city;
            State = _state;
            PostalCode = _postalCode;
            Country = _country;
        }

        private void validarCampos(string _street, int _number, string _complement, string _city, string _state, string _postalCode, string _country) 
        {
            if (_street == null || _street.Equals(""))
            {
                throw new Exception("field street must be filled");
            }
            if (_number.Equals(0))
            {
                throw new Exception("field number must be filled");
            }
            if (_complement == null || _complement.Equals(""))
            {
                throw new Exception("field complement must be filled");
            }
            if (_city == null || _city.Equals(""))
            {
                throw new Exception("field city must be filled");
            }
            if (_state == null || _state.Equals(""))
            {
                throw new Exception("field state must be filled ");
            }
            if (_postalCode == null || _postalCode.Equals(""))
            {
                throw new Exception("field postal code must be filled");
            }
            if (_country == null || _country.Equals(""))
            {
                throw new Exception("field country must be filled");
            }

        }

    }
}
