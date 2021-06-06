using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaLosacco.API.Models
{
    public class InputDoctorModel
    {
        public string Name { get; }
        public string Crm { get; }

        public string Email { get; }
        public string PhoneNumber { get; }
        public List<String> Specialties { get; }
        public InputAddressModel Address { get; }

        public InputDoctorModel(string name, string crm, string email, string phoneNumber, List<string> specialties, InputAddressModel address)
        {
            Name = name;
            Crm = crm;
            Email = email;
            PhoneNumber = phoneNumber;
            Specialties = specialties;
            Address = address;
        }

    }
}
