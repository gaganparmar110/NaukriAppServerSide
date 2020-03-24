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
    public class FeedbackController
    {
        public FeedbackController()
        {
            this.FeedbackDomain = new FeedbackDomain();
        }

        [HttpPost]
        public IActionResult Post(Feedbacks feedbacks)
        {
            this.FeedbackDomain.FeedbackAdd(feedbacks);
            return Ok();
        }
        private FeedbackDomain FeedbackDomain { get; set; }
    }

}
