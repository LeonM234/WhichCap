using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WhichCap.Models;
using WhichCap.Repository;
using Microsoft.AspNet.Identity;

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

        // GET: api/feed/profile
        // OR (maybe) api/feed/{id}
        [Route("api/feed/{id}")]
        public IEnumerable<Which> GetById()
        {
            string userId = User.Identity.GetUserId();
            if (userId != null)
            {
                return _db.GetWhichesByUserId(userId);
            }
            return _db.All();
            // Not sure all is necessary
            // Only need to get by ID for profile section
        }

        // POST: api/feed
        [Route("api/feed/")]
        public HttpResponseMessage Post(Which which)
        {
            which.ApplicationUserID = User.Identity.GetUserId();
            _db.Add(which);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        //// PUT: api/feed/{id}
        //[Route("api/feed/{id}")]
        //public HttpResponseMessage Put(Which which)
        //{
        //    which.ID = User.Identity.GetUserId();
        //    _db.Add(which);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}
    }
}