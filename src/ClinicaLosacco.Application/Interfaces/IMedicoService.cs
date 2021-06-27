
using ClinicaLosacco.Application.InputModels;
using ClinicaLosacco.Application.ViewModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ClinicaLosacco.Application.Interfaces
{
    public interface IMedicoService
    {
        Task<IEnumerable<MedicoViewModel>> GetAll();
        Task<MedicoViewModel> GetById(int id);
        void Add(MedicoInputModel medicoInputModel);
        Task<ValidationResult> Update(MedicoInputModel medicoInputModel);
        Task<ValidationResult> Remove(int id);
    }
}
