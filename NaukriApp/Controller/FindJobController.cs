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
    public class FindJobController
    {
        public FindJobController()
        {

        }
        [HttpGet]
        public IActionResult Get()
        {
            var Jobs = this.FindJobDomain.Get();
            return Ok(Jobs);

        }
        public FindJobDomain FindJobDomain { get; set; }
    }
}
