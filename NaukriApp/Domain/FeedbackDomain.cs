using Naukri.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriApp.Domain
{
    public class FeedbackDomain:BaseDomain
    {
        public void FeedbackAdd(Feedbacks feedbacks)
        {
            this.ExecuteNonQuery($"insert into ProfessionalEmploymentDetails values ('{feedbacks.UserId}','{feedbacks.Message}')");
        }
    }
}
