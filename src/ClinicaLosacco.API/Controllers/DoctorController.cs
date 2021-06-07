using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicaLosacco.Application.ViewModels;
using ClinicaLosacco.Application.ViewModels.Request;

namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorController : ControllerBase
    {

        private readonly ILogger<DoctorController> _logger;



        [HttpPost]
        public OkResult Create(InputDoctorModel inputDoctorModel)
        {
            // colocar o caso de uso aqui.;
            _logger.LogInformation("chegou na controller");
            return Ok();
        }
    }
}
