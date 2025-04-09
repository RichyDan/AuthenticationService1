
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    public class UserController : ControllerBase
    {
        [ApiController]
        [Route("[controller]")]
        public UserController()
        {
            var logger = new Logger();

            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибки в программе");
        }
    }
}
