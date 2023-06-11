using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    public class SmallHappyMealBuilder : IHappyMealBuilder
    {
        private HappyMeal happyMeal = new HappyMeal();
        public HappyMeal GetHappyMeal()
        {
            return happyMeal;
        }

        public void SetDrink()
        {
            happyMeal.Drink = "Coke";
        }

        public void SetMainItem()
        {
            happyMeal.MainItem = "Small Hamburger";
        }

        public void SetSize()
        {
            happyMeal.Size = "Small";
        }

        public void SetToy()
        {
            happyMeal.Toy = "Pencil";
        }
    }
}
