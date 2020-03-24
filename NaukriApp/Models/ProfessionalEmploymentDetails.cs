using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukri.com.Model
{
    public class ProfessionalEmploymentDetails
    {
        public int EmployeId { get; set; }
        public int UserId { get; set; }
        public string CurrentCompany { get; set; }
        public string Skills { get; set; }
        public string Industry { get; set; }
        public string AnnualSalary { get; set; }
      
    }
}
