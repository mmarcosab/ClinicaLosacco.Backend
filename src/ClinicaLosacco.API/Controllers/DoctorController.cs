using Microsoft.AspNetCore.Mvc;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {

        [HttpPost]
        public OkResult Create()
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

        [HttpGet("{doctorId}")]
        public OkResult GetById(int doctorId)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpDelete("{doctorId}")]
        public OkResult Inactivate(int id)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

    }
}
