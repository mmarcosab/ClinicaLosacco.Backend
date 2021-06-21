using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaLosacco.API.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthCheckController : Controller
    {
        [HttpGet]
        public string healthcheck()
        {
            return "200 OK";
        }
    }
}
