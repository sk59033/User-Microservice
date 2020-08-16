using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using User_Microservice.Services;
using User_Microservice.ViewModel;

namespace User_Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userServce;

        public UserController(IUserService UserService)
        {
            _userServce = UserService;
        }

        [HttpGet("{id:int}")]
        public ActionResult GetById(int id)
        {
            var result = _userServce.GetById(id);

            if (result == null)
            {
                return NotFound();
            }
            UserViewModel user = new UserViewModel
            {
                Name = result.Name,
                Age = result.Age,
                Email = result.Email
            };
            return Ok(user);
        }
    }
}
