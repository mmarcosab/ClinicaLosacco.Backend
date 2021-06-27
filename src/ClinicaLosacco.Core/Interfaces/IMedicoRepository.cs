

using ClinicaLosacco.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ClinicaLosacco.Core.Services
{
    public interface IMedicoRepository
    {
        Task<List<MedicoDb>> GetAll();
        Task<MedicoDb> GetById(int id);
        void Add(MedicoDb medico);
        void Update(MedicoDb medico);
        void Remove(MedicoDb medico);
    }
}
