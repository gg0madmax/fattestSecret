using Microsoft.AspNetCore.Mvc;

namespace fattestSecret.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver2_0)]
    [Route("{version:apiVersion}/users")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {

    }
}
