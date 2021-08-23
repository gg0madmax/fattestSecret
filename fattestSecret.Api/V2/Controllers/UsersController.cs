using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fattestSecret.Api.V2.Controllers
{
    [ApiController]
    [ApiVersion(Consts.Ver2_0)]
    [Route("{version:apiVersion}/Users")]
    [Produces("application/json")]
    public class UsersController : ControllerBase
    {

    }
}
