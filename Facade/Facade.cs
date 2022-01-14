using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    public class Facade
    {
        List<char> one = new();
        List<char> two = new();
        List<char> three = new();
        List<char> four = new();
        List<char> five = new();

        string input = Console.ReadLine();
        public void Save()
        {
            if (input.Length != 5)
            {
                Console.WriteLine("Exiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);
            }
            else
            {
                one.Add(input[0]);
                two.Add(input[1]);
                three.Add(input[2]);
                four.Add(input[3]);
                five.Add(input[4]);
            }
        }

        public void Load()
        {
            char[] word = { one.First(), two.Last(), three.Last(), four.Last(), five.Last() };
            Console.WriteLine(word);
        }
    }
}
