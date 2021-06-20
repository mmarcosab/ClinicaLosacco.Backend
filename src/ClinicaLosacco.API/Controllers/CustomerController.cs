using Microsoft.AspNetCore.Mvc;
using ClinicaLosacco.Application.ViewModels.Request;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
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

        [HttpGet("{customerId}")]
        public OkResult GetById(int customerId)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

        [HttpDelete("{customerId}")]
        public OkResult Inactivate(int id)
        {
            // colocar o caso de uso aqui.;
            return Ok();
        }

    }
}
