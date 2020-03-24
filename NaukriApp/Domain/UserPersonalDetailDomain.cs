using Naukri.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukri.com.Domain
{
    public class UserPersonalDetailDomain:BaseDomain
    {
        public void UserDetailAdd(UserPersonalDetails userPersonalDetails)
        {
            this.ExecuteNonQuery($"insert into UserPersonalDetails values ('{userPersonalDetails.UserName}','{userPersonalDetails.EmailId}','{userPersonalDetails.CreatePassword}','{userPersonalDetails.MobileNumber}','{userPersonalDetails.CurrentLocation}','{userPersonalDetails.HighestQualification}','{userPersonalDetails.CurrentPercentage}',{userPersonalDetails.SelectedCategory},'{userPersonalDetails.Resume}')");
        }
   

    }
}
