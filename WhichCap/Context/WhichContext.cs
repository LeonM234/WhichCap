﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WhichCap.Models;

namespace WhichCap.Context
{
    public class WhichContext : DbContext
    {
        public DbSet<Which> Whiches { get; set; }
    }
}