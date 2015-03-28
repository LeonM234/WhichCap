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

        // GET: api/feed/{id}
        [Route("api/feed/{id}")]
        public IEnumerable<Which> GetById()
        {
            string userId = User.Identity.GetUserId();
            if (userId != null)
            {
                return _db.GetWhichesByUserId(userId);
            }
            return _db.All();
            // Not sure _db.All() is necessary
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

        // PUT: api/{id}/voteforfirst
        [Route("api/{id}/voteforfirst")]
        [HttpPost]
        public HttpResponseMessage PostVote1(int id)
        {
            _db.AddFirstVote(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // PUT: api/{id}/voteforsecond
        [Route("api/{id}/voteforsecond")]
        [HttpPost]
        public HttpResponseMessage PostVote2(int id)
        {
            _db.AddSecondVote(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}