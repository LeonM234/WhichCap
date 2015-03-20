using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WhichCap.Models;

namespace WhichCap.Repository
{
    public interface IWhichRepository
    {
        int GetCount();
        void Add(Which E);
        void Delete(Which E);
        void Clear();
        IEnumerable<Which> All();
        IEnumerable<Which> GetWhichesByUserId(string userId);
    }
}