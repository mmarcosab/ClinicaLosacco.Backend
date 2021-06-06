﻿namespace ClinicaLosacco.API.Models
{
    public class OutPutAddressModel
    {
        public string Street { get; }
        public int Number { get;}
        public string Complement { get; }
        public string City { get; }
        public string State { get; }
        public string PostalCode { get; }
        public string Country { get; }


        public OutPutAddressModel(string street, int number, string complement, string city, string state, string postalCode, string country)
        {
            Street = street;
            Number = number;
            Complement = complement;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }
    }
}
