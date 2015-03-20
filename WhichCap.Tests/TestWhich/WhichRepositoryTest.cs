using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhichCap.Repository;
using WhichCap.Models;
using System.Collections.Generic;

namespace WhichCap.Tests.TestWhich
{
    [TestClass]
    public class WhichRepositoryTest
    {
        private static WhichRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new WhichRepository();
            repo.Clear();
        }

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Which("timmy", "Shoes", "www.awesomepic.com", "www.stupidpic.com", 12, 200, false));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void DBGetWhichByUserID()
        {
            Which testwhich = new Which("bcfac595-1a3f-44e9-b4cc-105de3c581bb", "Dog", "Dog1pic.com", "Dog2pic.com", 100, 246, false);
            repo.Add(testwhich);
            List<Which> which = repo.GetWhichesByUserId("bcfac595-1a3f-44e9-b4cc-105de3c581bb") as List<Which>;
            Assert.AreEqual(1, repo.GetCount());
        }
    }
}
