using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class Roof : IPart
    {
        public static int counter_Roof = 0;
        public Roof() { counter_Roof++; }
        public void What_Done(Worker w)
        {
            Console.WriteLine($"\nWorker {w.name} built roof");
        }
    }
}
