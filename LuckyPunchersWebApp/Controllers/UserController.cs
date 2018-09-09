using Infrastructure.Model.User;
using Manager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyPunchersWebApp.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        protected UserManager _userManager;

        public UserController(UserManager userManager)
        {
            _userManager = userManager;
        }

        [Route("login/email")]
        [HttpPost]
        public async Task<IActionResult> AuthEmail([FromBody]UserLoginModel model)
        {
            return Ok(await _userManager.TokenEmail(model));
        }
    }
}
