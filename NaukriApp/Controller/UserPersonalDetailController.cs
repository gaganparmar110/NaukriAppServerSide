using Microsoft.AspNetCore.Mvc;
using Naukri.com.Domain;
using Naukri.com.Model;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Naukri.com.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserPersonalDetailController
    {
        public UserPersonalDetailController()
        {
            this.UserPersonalDetailDomain = new UserPersonalDetailDomain();
        }
        [HttpPost]
        public IActionResult Post(UserPersonalDetails userPersonalDetails)
        {
            this.UserPersonalDetailDomain.UserDetailAdd(userPersonalDetails);
            return Ok();
        }

        private UserPersonalDetailDomain UserPersonalDetailDomain { get; set; }


    }
}
