using Naukri.com.Model;
using NaukriApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApp.Domain
{
    public class FindJobDomain
    {

        public List<vFindJobs> Get()
        {
            var reader = this.GetReader($"select * from vFindJobs");
            var vFindJobs = new List<vFindJobs>();
            while (reader.Read())
            {
                var findjob = new vFindJobs();
               
                findjob.CompanyId = reader.GetInt32(1);
                findjob.CompanyCategoryName = reader.GetString(2);
                findjob.LocationName = reader.GetString(3);
                findjob.RecruitmentName = reader.GetString(4);
                findjob.Openings = reader.GetInt32(5);
              

                vFindJobs.Add(findjob);
            }
            return vFindJobs;
        }

       
    }
}
