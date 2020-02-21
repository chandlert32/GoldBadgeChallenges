using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Badge_Challenege
{
    [TestClass]
    public class BadgeRepoTests
    {
        [TestMethod]
        public void ShouldReturnADictionary()
        {
            BadgeRepo repo = new BadgeRepo();

            string badgeID1 = "1";
            string badgeID2 = "2";

            var doors = new List<string>();
            doors.Add("A1");
            doors.Add("A5");

            var badges = repo.GetBadges(); 


            repo.CreateBadge(badgeID1, doors);
            repo.CreateBadge(badgeID2, doors);

            int actual = badges.Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldAddNewBadge()
        {
            BadgeRepo repo = new BadgeRepo();

            string badgeID1 = "1";
            string badgeID2 = "2";

            var doors = new List<string>();
            doors.Add("A1");
            doors.Add("A5");

            var badges = repo.GetBadges();

            repo.CreateBadge(badgeID1, doors); 
            repo.CreateBadge(badgeID2, doors); 

            int actual = badges.Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
