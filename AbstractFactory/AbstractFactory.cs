using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class AbstractFactory
    {
        public IFactory GetFactory()
        {
            Console.WriteLine("What type of animal do you want, dog or cat?");
            var factoryType = Console.ReadLine();

            if (factoryType.ToLower() == "dog")
            {
                Console.WriteLine($"you typed {factoryType}, creating dog factory.......");
                return new DogFactory();
            }
            else if (factoryType.ToLower() == "cat")
            {
                Console.WriteLine($"you typed {factoryType}, creating cat factory......");
                return new CatFactory();
            }
            else
            {
                Console.WriteLine($"No {factoryType} factory found");
                return null;
            }


        }
    }
}
