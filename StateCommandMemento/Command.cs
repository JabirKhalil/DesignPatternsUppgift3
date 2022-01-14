using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    public class Command : ICommand
    {
        public IMachine Machine { get; set; }
        public string Text { get; set; }

        public Command(IMachine machine,string text)
        {
            Machine = machine;
            Text = text;
        }
        public void Execute()
        {
            Machine.Print(Text);
        }
    }
}
