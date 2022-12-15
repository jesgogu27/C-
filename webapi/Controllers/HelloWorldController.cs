using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        IHelloworldService _helloworldService;
        private readonly ILogger<HelloWorldController> _loggerHelloWorld;

        public HelloWorldController(IHelloworldService helloworldService, ILogger<HelloWorldController> loggerHelloWorld)
        {
            _helloworldService = helloworldService;
            _loggerHelloWorld = loggerHelloWorld;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _loggerHelloWorld.LogInformation("Estas en el Hola Mundo");
            return Ok(_helloworldService.GetHelloWorld());
        }
    }
}