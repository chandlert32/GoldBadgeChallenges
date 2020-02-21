using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge_Challenege
{
    public class BadgeRepo
    {
        private readonly Dictionary<string, List<string>> _badges = new Dictionary<string, List<string>>();

        public void CreateBadge(string badgeID, List<string> doors)
        {
            _badges.Add(badgeID, doors);
        }

        public Dictionary<string, List<string>> GetBadges()
        {
            return _badges;
        }
    }
}

