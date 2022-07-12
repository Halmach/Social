using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social
{
    public class RegisterController:Controller
    {

        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View("Home/Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(RegisterViewModel model)
        {
            return View("RegisterPart2", model);
        }
    }
}
