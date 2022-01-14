using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    public class PrintingIntsService : IPrintingIntsService
    {
        ReturningStrings ReturningStrings { get; set; }
        PrintingInts PrintingInts { get; set; }
        public PrintingIntsService()
        {
            ReturningStrings = new ReturningStrings() ;
            PrintingInts = new PrintingInts();
        }
        public int Converter()
        {
            var num = Int32.Parse(ReturningStrings.ReturnString());
            return num;
        }

        public void Print()
        {
            PrintingInts.Print(Converter());
        }
    }
}
