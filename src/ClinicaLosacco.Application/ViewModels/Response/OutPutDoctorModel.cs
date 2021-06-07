using System;
using System.Collections.Generic;

namespace ClinicaLosacco.Application.ViewModels.Request
{
    public class OutPutDoctorModel
    {
        public int Code { get; }
        public string Name { get; }
        public string Crm { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public List<String> Specialties { get; }
        public OutPutAddressModel Address { get; }

        public OutPutDoctorModel(int code, string name, string crm, string email, string phoneNumber, List<string> specialties, OutPutAddressModel address)
        {
            Code = code;
            Name = name;
            Crm = crm;
            Email = email;
            PhoneNumber = phoneNumber;
            Specialties = specialties;
            Address = address;
        }
    }
}
