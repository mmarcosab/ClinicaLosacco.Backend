using ClinicaLosacco.Application.ViewModels;
using ClinicaLosacco.Application.ViewModels.Request;
using System.Threading.Tasks;

namespace ClinicaLosacco.Application.Services
{
    interface IDoctorService
    {
        string Create(InputDoctorModel inputDoctorModel);
    }
}
