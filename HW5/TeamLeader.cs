using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class TeamLeader :  IWorker
    {
 
        public string name { get; set; }

        public void What_was_done()
        {
            Console.WriteLine($"\nTemleader {name} say: \nWe built: \n{Basement.counter_Basement} basement \n{Walls.wall} walls \n{Door.counter_Door} door \n{Window.window} windows \n{Roof.counter_Roof} roof");
        }
    }

   
}
