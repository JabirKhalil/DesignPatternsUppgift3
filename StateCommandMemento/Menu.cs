using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Menu
    {
        public static void DrawMenu() { 
        PrintMachine printer = new();
        var commandService = new CommandService(printer);
        MachineMemento machineMemento = printer.CreateMemento();

        // Draw Menu

        Console.WriteLine("---------------------");
            Console.WriteLine("      Printer    ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: PowerSwitch");
            Console.WriteLine("B: Enter word to print");
            Console.WriteLine("C: Reset and turn off");
            Console.WriteLine("X: Quit Program\n");

            while (true)
            {              
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                    printer.PowerSwitch();                       
                            foreach (var word in printer.TextList)
                            {
                                commandService.Execute(word.Text);
                            }
                        printer.TextList.Clear();
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Enter word:");
                        var inputWord = Console.ReadLine();
                        commandService.Execute(inputWord);                     
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Reset and turn off");
                        machineMemento.Restore();
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
