using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Flyweight
{
    public abstract class Character
    {
        protected string name;
        protected Image image;
        protected double hp;
        protected int speed;
        protected double damage;

        public virtual void Display()
        {
            Console.WriteLine($"{name}: hp - {hp}, speed - {speed}, damage - {damage}. Image: {image.Name}");
        }
    }
}
