using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPrincples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        public readonly List<string> authorizedUsers;
        public BaseController() 
        {
            authorizedUsers = new List<string>() { "Osaks", "Efos", "Sharon" };
        }
    }
}
