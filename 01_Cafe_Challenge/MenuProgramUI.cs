using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01_Cafe_Challenge.MenuTest;

namespace _01_Cafe_Challenge
{
    class ProgramUI
    {
        private MenuRepo _menuRepo = new MenuRepo();

        public void Run()
        {
            SeedMenu();

            RunStartMenu();
        }

        private void SeedMenu()
        {
            List<string> ingsList = new List<string>();
            ingsList.Add("patty");
            ingsList.Add("buns");

            Foods item1 = new Foods(1, "Hamburger", "Two buns and a beef patty", ingsList, 8);
            Foods item2 = new Foods(2, "Cheeseburger", "Two buns, beef patty, and cheese", ingsList, 9);
            Foods item3 = new Foods(3, "Turkey Burger", "Two buns, turkey patty", ingsList, 10);

            _menuRepo.AddFoodToMenu(item1);
            _menuRepo.AddFoodToMenu(item2);
            _menuRepo.AddFoodToMenu(item3);
        }
        
        private void Home()
        {
            Console.Clear();

            Console.WriteLine("1. Add food to menu. \n" +
                "2. Delete food from menu. \n" +
                "3. View menu. \n" +
                "4. Exit.");
        }

        private void RunStartMenu()
        {
           RunStartMenu();

            bool runProgram = true;

            while (runProgram)
            {
                int choice = GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        AddFoodToMenu();
                        break;
                    case 2:
                        DeleteFoodFromMenu();
                        break;
                    case 3:
                        GetMenu();
                        break;
                    case 4:
                        runProgram = false;
                        break;
                    default:
                        RunStartMenu();
                        break;
                }
            }
        }

        
        private int GetMenuChoice()
        {
            Console.WriteLine("menu choice.");
            string userChoice = Console.ReadLine();
            int choice = Int32.Parse(userChoice);

            return choice;
        }

        private void AddFoodToMenu()
        {
            Console.Clear();

            Console.WriteLine("Name the food you would like to add?");
            string mealName = Console.ReadLine();

            Console.WriteLine("What number do you want this to have?");
            string mealNum = Console.ReadLine();

            Console.WriteLine("Enter a description of this food.");
            string desc = Console.ReadLine();

            Console.WriteLine("Enter the price of the food.");
            string price = Console.ReadLine();

            Foods itemAdded = new Foods();
            _menuRepo.AddFoodToMenu(itemAdded);

            Console.WriteLine("Food has been added to the menu.");
            RunStartMenu();
        }

        private void DeleteFoodFromMenu()
        {
            Console.Clear();

            Console.WriteLine("What food would you like to delete from the menu?");
            var mealName = Console.ReadLine();
            var selectedItem = _menuRepo.FindFoodOnMenu(mealName);

            _menuRepo.DeleteFoodFromMenu(selectedItem);

            Console.WriteLine("Food has been deleted.");
            RunStartMenu();
        }

        private void GetMenu()
        {
            Console.Clear();

            var menu = _menuRepo.GetList();

            foreach (var item in menu)
            {
                Console.WriteLine(item.Name);
            }

            RunStartMenu();
        }
    }
}
