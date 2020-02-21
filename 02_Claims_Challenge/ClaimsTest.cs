using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _02_Claims_Challenge.Claims;

namespace _02_Claims_Challenge
{
    [TestClass]
    public class ClaimsTest
    {
        [TestClass]
        public class Komodo_Claims_Repository_Tests
        {
            private Claims_Repository _claimRepo;

            [TestMethod]
            public void AddToQueue()
            {
                Claims claims = new Claims();
                _claimRepo = new Claims_Repository();

                _claimRepo.AddtoQueue(claims);

                int expected = 1;
                int actual = _claimRepo.GetClaims().Count;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
