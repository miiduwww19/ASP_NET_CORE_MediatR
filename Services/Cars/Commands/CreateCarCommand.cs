using MediatR;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
namespace Services.Cars.Commands
{
    public class CreateCarCommand : IRequest<Response<Car>> 
    {

    }
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Response<Car>>
    {
        public Task<Response<Car>> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            if (false)
            {
                return Task.FromResult(Response.Fail<Car>("already exist!"));
            }
            return Task.FromResult(Response.Ok(new Car { Name = "Mazda" }, "Car Created"));
        }
    }


}
