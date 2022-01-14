using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class PrintMachine : IMachine, IMachineState
    {
        public IMachineState MachineState { get; set; }
        public List<Command> TextList { get; set; }

        public PrintMachine()
        {
            MachineState = new MachineOff();
            TextList = new List<Command>();
        }

        public void PowerSwitch()
        {
            MachineState.PowerSwitch();
            if (MachineState is MachineOff)
            {
                MachineState = new MachineOn();
            }
            else
            {
                MachineState = new MachineOff();
            }
        }

        public void Print(string text)
        {
            Console.WriteLine("\nPrinting...");
            Console.WriteLine($"{text}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, TextList);
        }

    }


}
