using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge_Challenege
{
    public class Badge
    {
        public Badge(string badgeID, List<string> doors)
        {
            BadgeID = badgeID;
            AllDoors = doors;
        }

        public string BadgeID { get; set; }
        public List<string> AllDoors { get; set; }
    }
}
