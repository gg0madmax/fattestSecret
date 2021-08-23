using Microsoft.AspNetCore.Mvc;

namespace fattestSecret.Api.V1.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver1_0)]
    [Route("{version:apiVersion}/Users")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {

    }
}
