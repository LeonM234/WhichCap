using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WhichCap.Models
{
    public class Which
    {
        public int ID { get; set; }

        public string ApplicationUserID { get; set; }

        // UserID here?

        // Need MaxChar (or something) of 150, and min of...1?
        // Example max case:  Which... set of earings should I buy my wife?
        // Example min case: Which... T?  (compare two fonts)
        public string Title { get; set; }

        // Not sure if any extra parameters required
        public string Pic1Url { get; set; }

        public string Pic2Url { get; set; }

        public int Vote1 { get; set; }

        public int Vote2 { get; set; }

        public bool Done { get; set; }
    }

    public class WhichDBContext : DbContext
    {
        public DbSet<Which> Whiches { get; set; }
    }
}