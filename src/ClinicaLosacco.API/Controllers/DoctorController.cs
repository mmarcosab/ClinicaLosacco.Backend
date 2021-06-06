using ClinicaLosacco.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClinicaLosacco.APi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpPost]
        public OutPutDoctorModel create()
        {
            // colocar o caso de uso aqui.;
        }
    }
}
