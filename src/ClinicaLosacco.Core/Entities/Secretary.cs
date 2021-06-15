using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Secretary : Employee
    {       
        public Secretary(string name, string email, string phoneNumber, Address address) : base(name, email, phoneNumber, address)
        {
     
        }

        //TODO - méodo marcar consulta

        public Consultation makeAnAppointment(Doctor doctor, Customer customer, DateTime scheduledDate)
        {
            return new Consultation(doctor, customer, scheduledDate);
        }
    }
}
