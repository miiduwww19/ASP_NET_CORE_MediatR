using MediatR;
using Microsoft.AspNetCore.Http;
using Services;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace ASP_NET_CORE_MediatR.Infrastructure
{
    public class UserIdPipe<TIn, TOut> : IPipelineBehavior<TIn, TOut>
    {
        private HttpContext _httpContext;
        public UserIdPipe(IHttpContextAccessor accessor)
        {
            _httpContext = accessor.HttpContext;
        }

        public Task<TOut> Handle(
            TIn request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TOut> next)
        {
            //var UserId = _httpContext.User.Claims
            //    .FirstOrDefault(x => x.Type.Equals(ClaimTypes.NameIdentifier))
            //    .Value;

            if (request is BaseRequest br)
            {
                br.UserId = "Mohamed Alaa";
            }

            return next();
        }
    }

}
