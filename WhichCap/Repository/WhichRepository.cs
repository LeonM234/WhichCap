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

        public WhichRepository()
        {
            _db = new WhichContext();
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

        public IEnumerable<Which> GetWhichesByUserId(string userId)
        {
            var WhichesById = from w in _db.Whiches
                              where w.ApplicationUserID == userId
                              select w;
            return WhichesById.ToList();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}