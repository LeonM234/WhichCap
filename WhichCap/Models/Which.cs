﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Which()
        {
            // empty constructor
        }

        public Which(string applicationUserID, string Title, string Pic1Url, string Pic2Url, int Vote1, int Vote2, bool Done)
        {
            this.ApplicationUserID = ApplicationUserID;
            this.Title = Title;
            this.Pic1Url = Pic1Url;
            this.Pic2Url = Pic2Url;
            this.Vote1 = Vote1;
            this.Vote2 = Vote2;
            this.Done = Done;
        }
    }
}