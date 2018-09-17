using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChallengeRevision_API.Controllers
{
    public class ExamplesController : ApiController
    {
        // GET: api/Examples
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Examples/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
