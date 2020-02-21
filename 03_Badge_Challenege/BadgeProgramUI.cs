using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badge_Challenege
{
    class ProgramUI
    {
        private readonly BadgeRepo _repo = new BadgeRepo();
        private bool continueToLoop = true;

        public void Run()
        {
            Seed();

            RunStartMenu();
        }

        private void Seed()
        {
            string badgeID1 = "1";
            string badgeID2 = "2";

            var doors = new List<string>();

            doors.Add("A1");
            doors.Add("A5");

            _repo.CreateBadge(badgeID1, doors);
            _repo.CreateBadge(badgeID2, doors);
        }

        private void RunStartMenu()
        {
            StartMenu();

            while (continueToLoop)
            {
                int choice = UserInput();

                switch (choice)
                {
                    case 1:
                        AddBadge();
                        break;
                    case 2:
                        UpdateBadge(_repo.GetBadges());
                        break;
                    case 3:
                        GetBadges(_repo.GetBadges());
                        break;
                    default:
                        RunStartMenu();
                        break;
                }
            }
        }

        private void StartMenu()
        {
            Console.Clear();

            Console.WriteLine( "1. Add a badge \n" +
                "2. Update a badge \n" +
                "3. List all badges \n" +
                "4. Exit program");
        }

        private int UserInput()
        {
            int choice = Int16.Parse(Console.ReadLine());
            return choice;
        }

        private void AddBadge()
        {
            Console.WriteLine("What is the badge number?");
            string badgeID = Console.ReadLine();

            var doors = new List<string>();

            while (continueToLoop)
            {
                Console.WriteLine("Looking to add a door:");
                string door = Console.ReadLine();
                doors.Add(door);

                Console.WriteLine("Wnat to add another door? y or n");
                string answer = Console.ReadLine();

                if (answer != "y")
                {
                    _repo.CreateBadge(badgeID, doors);
                    RunStartMenu();
                }
            }
        }

        private void GetBadges(Dictionary<string, List<string>> badges)
        {
            foreach (var badge in badges)
            {
                string stringedList = string.Join(", ", badge.Value);
                Console.WriteLine($"Badge Number: {badge.Key}\t Accessible Doors: {stringedList}");
            }

            Console.WriteLine("1. Return to menu");
            int choice = UserInput();
            if (choice == 1)
                RunStartMenu();
        }

        private Dictionary<string, List<string>> FindBadge()
        {
            Console.WriteLine("Badge ID?");
            string badgeID = Console.ReadLine();

            var badges = _repo.GetBadges();

            var foundBadge = new Dictionary<string, List<string>>();



            return foundBadge;
        }

        private void UpdateBadge(Dictionary<string, List<string>> badge)
        {
            Console.WriteLine("What is the badge number?");
            string badgeID = Console.ReadLine();
        }
    }
}
