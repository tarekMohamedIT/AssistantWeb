using AssistantWeb.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssistantWeb.Controllers.api
{
    public class PricingController : ApiController
    {
        private AssistantDbContext _context;

        public PricingController()
        {
            _context = new AssistantDbContext();
        }

        [Route("api/plans")]
        public IHttpActionResult GetPlans()
        {
            var data = _context.Plans.ToList();

            return Ok(data);
        }
    }
}
