using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class MachineMemento
    {
        public PrintMachine Printer { get; set; }
        public List<Command> TextList { get; set; }

        public MachineMemento(PrintMachine printer, List<Command> textList)
        {
            Printer = printer;
            TextList = textList;
        }


        public void Restore()
        {
            Console.WriteLine("Reseting list and turning off...");
            Printer.TextList.Clear();
            Printer.MachineState = new MachineOff();

        }
    }
}
