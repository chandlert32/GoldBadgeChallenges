using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Cafe_Challenge
{
    [TestClass]
    public class MenuTest
    {
        [TestMethod]
        public void ShouldAddFoodToMenu()
        {
            MenuRepo _menuRepo = new MenuRepo();

            Foods item = new Foods();

            _menuRepo.AddFoodToMenu(item);

            var list = _menuRepo.GetList();

            int actual = list.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldRemoveFoodFromMenu()
        {
            MenuRepo _menuRepo = new MenuRepo();

            Foods item1 = new Foods();
            Foods item2 = new Foods();

            _menuRepo.AddFoodToMenu(item1);
            _menuRepo.AddFoodToMenu(item2);

            _menuRepo.DeleteFoodFromMenu(item1); 


            var list = _menuRepo.GetList();

            int actual = list.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldFindSearchedFoodOnMenu()
        {
            MenuRepo _menuRepo = new MenuRepo();

            Foods item1 = new Foods();
            item1.Name = "Burger";
            _menuRepo.AddFoodToMenu(item1);

            Foods actual = _menuRepo.FindFoodOnMenu("Burger");
            Foods expected = item1;

            Assert.AreEqual(expected, actual);
        }
    }
}

