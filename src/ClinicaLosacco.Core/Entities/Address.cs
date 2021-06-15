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


        public Address(string street, int number, string complement, string city, string state, string postalCode, string country)
        {
            validarCampos(street, number, complement, city, state, postalCode, country);
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        private void validarCampos(string street, int number, string complement, string city, string state, string postalCode, string country) 
        { //TODO - usar o nameof para os campos
            if(String.IsNullOrEmpty(street))
            {
                throw new ArgumentException("field " + nameof(street) + " must be filled");
            }
            if (number.Equals(0))
            {
                throw new ArgumentException("field " + nameof(number) + " must be filled");
            }
            if (String.IsNullOrEmpty(complement))
            {
                throw new ArgumentException("field " + (nameof(complement)) + " complement must be filled");
            }
            if (String.IsNullOrEmpty(city))
            {
                throw new ArgumentException("field " + (nameof(city)) + " must be filled");
            }
            if (String.IsNullOrEmpty(state))
            {
                throw new ArgumentException("field " + (nameof(state)) + " must be filled ");
            }
            if (String.IsNullOrEmpty(postalCode))
            {
                throw new ArgumentException("field " + (nameof(postalCode)) + " must be filled");
            }
            if (String.IsNullOrEmpty(country))
            {
                throw new ArgumentException("field " + (nameof(country)) + " must be filled");
            }

        }

    }
}
