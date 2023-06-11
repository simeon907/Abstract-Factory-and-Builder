using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    public interface IHappyMealBuilder
    {
        void SetSize();
        void SetMainItem();
        void SetDrink();
        void SetToy();

        HappyMeal GetHappyMeal();
    }
}
