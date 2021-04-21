using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class Window : IPart
    {
        public static int window { get; set; }
        void NextWindow()
        {
            window++;
        }
        public void What_Done(Worker w)
        {
            Console.WriteLine($"\nWorker {w.name} insert {window+1}th window");
            NextWindow();
        }
    }
}
