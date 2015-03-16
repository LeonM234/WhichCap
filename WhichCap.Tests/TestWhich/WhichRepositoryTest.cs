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

        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }

        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Which());
        }
    }
}
