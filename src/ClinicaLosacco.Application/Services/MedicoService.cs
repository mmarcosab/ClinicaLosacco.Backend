using ClinicaLosacco.Application.InputModels;
using ClinicaLosacco.Application.Interfaces;
using ClinicaLosacco.Application.ViewModels;
using ClinicaLosacco.Core.DbModels;
using ClinicaLosacco.Core.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


namespace ClinicaLosacco.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;
        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }
        public void Add(MedicoInputModel medicoInputModel)
        {
            var endereco = new EnderecoDb(medicoInputModel.Endereco.Rua,
                                        medicoInputModel.Endereco.Numero,
                                        medicoInputModel.Endereco.Complemento,
                                        medicoInputModel.Endereco.Cidade,
                                        medicoInputModel.Endereco.UF,
                                        medicoInputModel.Endereco.UF,
                                        medicoInputModel.Endereco.Pais);

            var medico = new MedicoDb(medicoInputModel.Nome,
                                    medicoInputModel.Email,
                                    medicoInputModel.Telefone,
                                    medicoInputModel.Crm,
                                    medicoInputModel.Especialidades,
                                    endereco);

            _medicoRepository.Add(medico);

        }

        public Task<IEnumerable<MedicoViewModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<MedicoViewModel> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ValidationResult> Register(MedicoInputModel medicoInputModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<ValidationResult> Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ValidationResult> Update(MedicoInputModel medicoInputModel)
        {
            throw new System.NotImplementedException();
        }

    }
}
