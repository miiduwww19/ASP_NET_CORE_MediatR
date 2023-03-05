using MediatR;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.NewFolder.NewFolder
{

    // 1- Create Command Query
    public class GetAllCarsQuery : BaseRequest, IRequest<IEnumerable<Car>> 
    { 

    }

    // 2- Create handler
    public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, IEnumerable<Car>>
    {
        // 3- Create constructor for if you want doing dependency injection here.
        public GetAllCarsQueryHandler()
        {

        }
        // 4- Implement the interface of "IRequestHandler".
        
        public async Task<IEnumerable<Car>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
        {
            // Some business logic

            // Returning list of Cars.
            return new[]
            {
                new Car { Name = $"Ford {request.UserId}" },
                new Car { Name = "Toyta" }
            };
        }
    }
}
