using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class Walls : IPart
    {
        public static int wall = 0;
        void NextWall()
        {
            wall++;
        }

        public void What_Done(Worker w)
        {
            Console.WriteLine($"\nWorker {w.name} biult {wall+1}th wall");
            NextWall();
        }
      
        
        
    }
}
