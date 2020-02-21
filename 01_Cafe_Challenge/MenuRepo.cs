

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_Challenge
{
    public class MenuRepo
    {
        private readonly List<Foods> _foodList = new List<Foods>();
        public void AddFoodToMenu(Foods menuFood)
        {
            _foodList.Add(menuFood);
        }

        public void DeleteFoodFromMenu(Foods menuFood)
        {
            _foodList.Remove(menuFood);
        }

        public List<Foods> GetList()
        {
            return _foodList;
        }

        public Foods FindFoodOnMenu(string name)
        {
            var menuFood = new Foods();

            foreach(var item in _foodList)
            {
                if (name == item.Name) 
                {
                    menuFood = item;
                    break;
                }
            }
            return menuFood;
        }
    }
}
