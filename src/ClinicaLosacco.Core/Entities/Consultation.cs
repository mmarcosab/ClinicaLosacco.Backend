using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.Entities
{
    public class Consultation
    {
        public Doctor Doctor { get; set; }
        public Customer Customer { get; set; }
        public DateTime ScheduledDate { get; set; } 

        public Consultation(Doctor _doctor, Customer _customer, DateTime _scheduledDate)
        {
            validarCampos(_doctor, _customer, _scheduledDate);
            Doctor = _doctor;
            Customer = _customer;
            ScheduledDate = _scheduledDate;
        }

        public void validarCampos(Doctor _doctor, Customer _customer, DateTime _scheduledDate)
        {
            if(_doctor == null)
            {
                throw new Exception("In a consultation doctor can not be null");
            }
            if (_customer == null)
            {
                throw new Exception("In a consultation customer can not be null");
            }
            if (_doctor == null)
            {
                throw new Exception("In a consultation scheduled date can not be null");
            }
        }
    }
}
