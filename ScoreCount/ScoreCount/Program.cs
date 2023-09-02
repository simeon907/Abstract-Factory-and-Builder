using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Woman woman = new Woman();
            Child child = new Child();

            Algorithm algorithm = new Algorithm();

            Console.WriteLine($"Man score: {man.Score}\nWoman score: {woman.Score}\nChild score: {child.Score}");

            algorithm.TemplateMethod(man, false);
            algorithm.TemplateMethod(man, true);
            algorithm.TemplateMethod(man, false);

            algorithm.TemplateMethod(woman, false);
            algorithm.TemplateMethod(woman, true);
            algorithm.TemplateMethod(woman, true);

            algorithm.TemplateMethod(child, true);
            algorithm.TemplateMethod(child, true);
            algorithm.TemplateMethod(child, true);

            Console.WriteLine("A few moments later...");
            Console.WriteLine($"Man score: {man.Score}\nWoman score: {woman.Score}\nChild score: {child.Score}");

            Console.ReadKey();
        }
    }
}
