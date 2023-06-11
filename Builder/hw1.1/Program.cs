using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IHappyMealBuilder bSmall = new SmallHappyMealBuilder();
            IHappyMealBuilder bBig = new BigHappyMealBuilder();

            director.Construct(bSmall);
            HappyMeal smallHappyMeal = bSmall.GetHappyMeal();
            Console.WriteLine("Small Happy Meal: ");
            smallHappyMeal.Display();

            director.Construct(bBig);
            HappyMeal bigHappyMeal = bBig.GetHappyMeal();
            Console.WriteLine("Big Happy Meal: ");
            bigHappyMeal.Display();

            Console.ReadKey();
        }
    }
}
