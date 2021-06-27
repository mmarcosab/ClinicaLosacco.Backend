using Microsoft.AspNetCore.Mvc;
using ClinicaLosacco.Application.InputModels;
using ClinicaLosacco.Application.Interfaces;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/medicos")]
    public class MedicoController : ControllerBase
    {

        private readonly IMedicoService _medicoService;
        
        public MedicoController(IMedicoService medicoService)
        {
            _medicoService = medicoService;
        }

        [HttpPost]
        public OkResult Create([FromBody] MedicoInputModel medicoInputModel)
        {
            _medicoService.Add(medicoInputModel);
            return Ok();
        }

        [HttpGet]
        public OkResult GetAll()
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpGet("{medicoId}")]
        public OkResult GetById(int doctorId)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpDelete("{medicoId}")]
        public OkResult Inactivate(int id)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

    }
}
