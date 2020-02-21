using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_Challenge
{
    public class Foods
    {
        public Foods() { }

        public int Num { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List <string> Ingredients { get; set; }
        public int Price { get; set; }

        public Foods(int num, string name, string description, List<string> ingredients, int price)
        {
            Num = num;
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Price = price;
        }

        

    }

}
