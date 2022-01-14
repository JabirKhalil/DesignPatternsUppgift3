using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
   public class CommandService
    {
        public PrintMachine Printer { get; set; }
        public CommandService(PrintMachine printer)
        {
            Printer = printer;
        }


        public void Execute(string userWord) // off
        {
            var text = new Command(Printer, userWord);

            if (Printer.MachineState is MachineOff)
            {
                Printer.TextList.Add(text);
                Console.WriteLine("\nPrinter is off... Saving word until printer is on.");
            }
            else
            {
                text.Execute();
            }
        }
    }
}
