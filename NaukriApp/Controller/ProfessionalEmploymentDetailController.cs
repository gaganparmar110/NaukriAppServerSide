using Microsoft.AspNetCore.Mvc;
using Naukri.com.Domain;
using Naukri.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApp.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalEmploymentDetailController
    {
       

        public ProfessionalEmploymentDetailController()
        {
            this.ProfessionalEmploymentDetailDomain = new ProfessionalEmploymentDetailDomain();
        }

        [HttpPost]
        public IActionResult Post(ProfessionalEmploymentDetails professionalEmploymentDetails)
        {
            this.ProfessionalEmploymentDetailDomain.EmployeDetailAdd(professionalEmploymentDetails);
            return Ok();
        }
        private ProfessionalEmploymentDetailDomain ProfessionalEmploymentDetailDomain { get; set; }
    }
}
