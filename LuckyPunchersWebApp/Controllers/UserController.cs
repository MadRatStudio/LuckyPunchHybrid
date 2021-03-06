﻿using Infrastructure.Model.User;
using Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckyPunchersWebApp.Controllers
{
    [Route("api/user")]
    [Authorize]
    public class UserController : Controller
    {
        protected UserManager _userManager;

        public UserController(UserManager userManager)
        {
            _userManager = userManager;
        }

        [Route("login/password")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AuthEmail([FromBody]UserLoginModel model)
        {
            return Ok(await _userManager.TokenEmail(model));
        }

        [Route("login/facebook")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AuthFacebook()
        {
            return Ok();
        }
    }
}
