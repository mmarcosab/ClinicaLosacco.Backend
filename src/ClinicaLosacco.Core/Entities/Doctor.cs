using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Doctor : Employee
    {
        public string Crm { get; set; }
        public List<String> Specialties { get; set; }
        
        public Doctor(string _name, string _email, string _phoneNumber, string _crm, List<string> _specialties, Address _address) : base(_name, _email, _phoneNumber, _address)
        {
            validarCampos(_crm, _specialties);
            Crm = _crm;
            Specialties = _specialties;
        }

        public void validarCampos(string _crm, List<string> _specialties)
        {
            if (_crm == null || _crm.Equals(""))
            {
                throw new Exception("field crm must be filled");
            }
            if (_specialties == null || _specialties.Count.Equals(0))
            {
                throw new Exception("field crm must be filled");
            }
        }
    }
}
