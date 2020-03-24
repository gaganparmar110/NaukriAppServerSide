using Microsoft.AspNetCore.Mvc;
using Naukri.com.Domain;
using Naukri.com.Model;
using NaukriApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApp.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserLoginController
    {
  
        private UserLoginDomain UserLoginDomain { get; set; }
        public UserLoginController()
        {
            this.UserLoginDomain = new UserLoginDomain();
        }
        [HttpPost]
        public IActionResult Post(UserPersonalDetails userPersonalDetails)
        {
            var isLoggedIn = this.UserLoginDomain.IsLogin(userPersonalDetails);
            return Ok(isLoggedIn);

        }

        private IActionResult Ok(int isLoggedIn)
        {
            throw new NotImplementedException();
        }
    }
}
