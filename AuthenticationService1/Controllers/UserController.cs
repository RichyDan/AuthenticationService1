
using AuthenticationService1.Logging;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            var logger = new Logger();

            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибке в программе");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                Login = "ivanov",
                Password = "11111111",
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "example@gmail.com"
            };
        }
    }
}
