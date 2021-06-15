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

        public Consultation(Doctor doctor, Customer customer, DateTime scheduledDate)
        {
            validarCampos(doctor, customer, scheduledDate);
            Doctor = doctor;
            Customer = customer;
            ScheduledDate = scheduledDate;
        }

        public void validarCampos(Doctor doctor, Customer customer, DateTime scheduledDate)
        {
            if(doctor == null)
            {
                throw new ArgumentNullException("In a consultation " + nameof(doctor) + " can not be null");
            }
            if (customer == null)
            {
                throw new ArgumentNullException("In a consultation " + nameof(customer) + " can not be null");
            }
            if (scheduledDate == null)
            {
                throw new ArgumentNullException("In a consultation " + nameof(scheduledDate) + " can not be null");
            }
        }
    }
}
