using ClinicaLosacco.Core.DbModels;
using ClinicaLosacco.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ClinicaLosacco.Infra.Persistencia.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AppDbContext _appDbContext;

        public MedicoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(MedicoDb medicoDb)
        {
            _appDbContext.Medicos.Add(medicoDb);
            _appDbContext.SaveChanges();
        }

        public Task<List<MedicoDb>> GetAll()
        {
            return _appDbContext.Medicos.ToListAsync();
        }

        public Task<MedicoDb> GetById(int id)
        {
            //MedicoDb m = _appDbContext.Medicos.FindAsync(id);
            //return _appDbContext.Medicos.FindAsync(id);
            throw new System.NotImplementedException();
        }

        public void Remove(MedicoDb medico)
        {
            throw new System.NotImplementedException();
        }

        public void Update(MedicoDb medico)
        {
            throw new System.NotImplementedException();
        }

    }
   
}
