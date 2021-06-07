
using ClinicaLosacco.Application.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaLosacco.Application.Services
{
    class DoctorService : IDoctorService
    {
        public string Create(InputDoctorModel inputDoctorModel)
        {
            Console.WriteLine(inputDoctorModel);
            return "teste ta chegando aqui";
        }
    }
}
