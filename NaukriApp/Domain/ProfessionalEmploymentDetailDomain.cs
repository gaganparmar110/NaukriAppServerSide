using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Naukri.com.Model;

namespace Naukri.com.Domain
{
    public class ProfessionalEmploymentDetailDomain:BaseDomain
    
    {
        public void EmployeDetailAdd(ProfessionalEmploymentDetails professionalEmploymentDetails)
        {
            this.ExecuteNonQuery($"insert into ProfessionalEmploymentDetails values ('{professionalEmploymentDetails.CurrentCompany}','{professionalEmploymentDetails.Skills}','{professionalEmploymentDetails.Industry}','{professionalEmploymentDetails.AnnualSalary}')");
        }
    }
}
