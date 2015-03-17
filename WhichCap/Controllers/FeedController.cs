using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WhichCap.Models;
using WhichCap.Repository;

namespace WhichCap.Controllers
{
    public class FeedController : ApiController
    {
        private static WhichRepository _db = new WhichRepository();

        // GET: api/feed
        [Route("api/feed")]
        public IEnumerable<Which> Get()
        {
            return _db.All();
        }
    }
}