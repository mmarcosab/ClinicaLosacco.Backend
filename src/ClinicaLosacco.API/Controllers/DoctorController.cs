using Microsoft.AspNetCore.Mvc;
using ClinicaLosacco.Application.ViewModels.Request;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {

        [HttpPost]
        public OkResult Create([FromBody] InputDoctorModel inputDoctorModel)
        {

            
            //_accessMongo.Add(inputDoctorModel);
            // colocar o caso de uso aqui.;

            return Ok();
        }

        [HttpGet]
        public OkResult GetAll()
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpGet]
        [Route("/{doctorId}")]
        public OkResult GetById(int doctorId)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpDelete]
        [Route("/{doctorId}")]
        public OkResult Inactivate(int id)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

    }
}
