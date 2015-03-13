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
            throw new NotImplementedException();
        }

        public void Delete(Which E)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Which> All()
        {
            throw new NotImplementedException();
        }

        public Which GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}