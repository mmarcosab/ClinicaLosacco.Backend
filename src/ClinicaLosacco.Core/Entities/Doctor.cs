using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    /// <summary>
    /// This class define a doctor of Clinica Losacco
    /// </summary>
    public class Doctor : Employee
    {
        public string Crm { get; set; }
        public List<String> Specialties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"> Represents the doctor's name and can not be null o empty </param>
        /// <param name="email">Represents the doctor's email and can not be null o empty </param>
        /// <param name="phoneNumber">Represents the doctor's phone number and can not be null o empty </param>
        /// <param name="crm">Represents the doctor's CRM and can not be null o empty </param>
        /// <param name="specialties">Represents the doctor's specialts and can not be null o empty </param>
        /// <param name="address">Represents the doctor's adrees and can not be null o empty </param>
        public Doctor(string name, string email, string phoneNumber, string crm, List<string> specialties, Address address) : base(name, email, phoneNumber, address)
        {
            validarCampos(crm, specialties);
            Crm = crm;
            Specialties = specialties;
        }

        public void validarCampos(string crm, List<string> specialties)
        {
            if (String.IsNullOrEmpty(crm))
            {
                throw new ArgumentException("field " + nameof(crm) + " must be filled");
            }
            if (specialties == null || specialties.Count.Equals(0))
            {
                throw new ArgumentException("field crm must be filled");
            }
        }
    }
}
