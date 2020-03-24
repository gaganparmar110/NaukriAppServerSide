using Naukri.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApp.Domain
{
    public class UserLoginDomain:BaseDomain
    {
        public int IsLogin(UserPersonalDetails userPersonalDetails)
        {
            var reader = this.GetReader($"select * from UserPersonalDetails where UserName='{userPersonalDetails.UserName}' and CreatePassword='{userPersonalDetails.CreatePassword}'");
            var IsLoggedIn = 0;
            while (reader.Read())
            {
                IsLoggedIn = 1;
            }
            return IsLoggedIn;
        }
    }
}
