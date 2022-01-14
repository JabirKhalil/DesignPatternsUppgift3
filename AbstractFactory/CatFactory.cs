using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory
{
    public class CatFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Cat(name);
        }
    }
}
