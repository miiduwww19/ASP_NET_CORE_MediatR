using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Cars.Commands;
using Services.Models;
using Services.NewFolder.NewFolder;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MediatR.Controllers
{
    [Route("cars")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // we inject the mediatR - this it the third party of implementation of mediatR
        [HttpGet]
        public Task<IEnumerable<Car>> Index()
        {
            return _mediator.Send(new GetAllCarsQuery());
        }

        [HttpPost]
        public Task<Response<Car>> Index([FromBody] CreateCarCommand command)
        {
            return _mediator.Send(command);
        }
    }
}
