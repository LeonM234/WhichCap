using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhichCap.Context;
using WhichCap.Models;

namespace WhichCap.Repository
{
    public class WhichRepository : IWhichRepository
    {
        private WhichContext _db;

        public WhichRepository(string connection="WhichContext")
        {
            _db = new WhichContext(connection);
            _db.Whiches.Load();
        }

        public int GetCount()
        {
            return _db.Whiches.Count<Models.Which>();
        }

        public void Add(Which E)
        {
            _db.Whiches.Add(E);
            _db.SaveChanges();
        }

        public void Delete(Which E)
        {
            _db.Whiches.Remove(E);
            _db.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _db.Whiches.RemoveRange(a);
            _db.SaveChanges();
        }

        public IEnumerable<Which> All()
        {
            var qu = from Which in _db.Whiches select Which;
            return qu.ToList<Which>();
        }

        // Passing in a string id here to make it work.  
        // In the model, id (or ID in the models case) is an int.
        // While the ApplicationUserID is a string.
        public Which GetById(string id)
        {
            var query = from Which in _db.Whiches
                        where Which.ApplicationUserID == id
                        select Which;
            return query.First<Which>();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}