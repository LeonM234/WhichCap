using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhichCap.Models;

namespace WhichCap.Repository
{
    public class WhichRepository : IWhichRepository
    {
        private WhichDBContext _dbContext;

        public int GetCount()
        {
            return _dbContext.Whiches.Count<Models.Which>();
        }

        public void Add(Which E)
        {
            _dbContext.Whiches.Add(E);
        }

        public void Delete(Which E)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Whiches.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Which> All()
        {
            var qu = from Which in _dbContext.Whiches select Which;
            return qu.ToList<Which>();
        }

        // Passing in a string id here to make it work.  
        // In the model, id (or ID in the models case) is an int.
        // While the ApplicationUserID is a string.
        public Which GetById(string id)
        {
            var query = from Which in _dbContext.Whiches
                        where Which.ApplicationUserID == id
                        select Which;
            return query.First<Which>();
        }
    }
}