using ClinicaLosacco.API.Models;
using ClinicaLosacco.Core.Entities;
using ClinicaLosacco.Core.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaLosacco.Core.UseCases
{
    class CreateDoctor : ICreateDoctor
    {
        OutPutDoctorModel ICreateDoctor.CreateDoctor(InputDoctorModel inputDoctorModel)
        {
            //TODO
            
            Console.WriteLine(inputDoctorModel);

            OutPutAddressModel address = new OutPutAddressModel("Rua de Teste", 250, "Apartamento 10", "Sao Paulo", "SP", "01234567", "Brasil");
            List<string> specialts = new List<string>();
            specialts.Add("cardiologista");
            OutPutDoctorModel doctor = new OutPutDoctorModel(1, "Maria", "teste@teste.com.br", "123456789", "2222222", specialts, address);
            
            
            return doctor;
        }
    }
}
