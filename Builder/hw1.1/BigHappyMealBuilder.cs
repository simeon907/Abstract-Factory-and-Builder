using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    internal class BigHappyMealBuilder : IHappyMealBuilder
    {
        private HappyMeal happyMeal = new HappyMeal();
        public HappyMeal GetHappyMeal()
        {
            return happyMeal;
        }

        public void SetDrink()
        {
            happyMeal.Drink = "Big Coke";
        }

        public void SetMainItem()
        {
            happyMeal.MainItem = "Double Cheeseburger";
        }

        public void SetSize()
        {
            happyMeal.Size = "XL";
        }

        public void SetToy()
        {
            happyMeal.Toy = "Horsey";
        }
    }
}
