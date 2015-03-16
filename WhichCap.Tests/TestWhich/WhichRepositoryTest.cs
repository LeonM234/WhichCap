using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhichCap.Repository;
using WhichCap.Models;

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
            repo.Add(new Which("Shoes", "www.awesomepic.com", "www.stupidpic.com", 12, 200, false));
            Assert.AreEqual(1, repo.GetCount());
        }
    }
}
