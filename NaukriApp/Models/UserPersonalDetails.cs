using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukri.com.Model
{
    public class UserPersonalDetails
    {
        public int UserId { get; set; }
       
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string CreatePassword { get; set; }
        public string MobileNumber { get; set; }
        public string CurrentLocation { get; set; }
        public string HighestQualification { get; set; }
        public string CurrentPercentage { get; set; }
        public int SelectedCategory { get; set; }
        public string Resume { get; set; }
    }
}
