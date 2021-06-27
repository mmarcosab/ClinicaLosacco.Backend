using Microsoft.AspNetCore.Mvc;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/secretaries")]
    public class SecretaryController : ControllerBase
    {

        [HttpPost]
        public OkResult Create([FromBody] object someObject)
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

        [HttpGet("{secretaryId}")]
        public OkResult GetById(int doctorId)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpDelete("{secretaryId}")]
        public OkResult Inactivate(int id)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpPost("{secretaryId}/consultations")]
        public OkResult CreateConsultation()
        {
            //_accessMongo.Add(inputDoctorModel);
            // colocar o caso de uso aqui.;
            return Ok();
        }

    }
}
