using ClinicaLosacco.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.UseCases.Interfaces
{
    public interface ICreateDoctor
    {
        public OutPutDoctorModel CreateDoctor(InputDoctorModel inputDoctorModel);
    }
}
