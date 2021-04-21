using System;

namespace HW5
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
           
            
            Worker worker1 = new Worker() {name = "Ivan"};
            Worker worker2 = new Worker() {name = "Sergiy"};
            Worker worker3 = new Worker() {name = "Bogdan"};
            

            Basement basement = new Basement();
            basement.What_Done(worker1);
            Walls wall = new Walls();
            wall.What_Done(worker2);
            wall.What_Done(worker2);
            wall.What_Done(worker3);
            wall.What_Done(worker1);
            Door door = new Door();
            door.What_Done(worker2);
            Window window = new Window();
            window.What_Done(worker2);
            window.What_Done(worker1);
            window.What_Done(worker3);
            window.What_Done(worker1);
            Roof roof = new Roof();
            roof.What_Done(worker3);

            TeamLeader leader = new TeamLeader() { name = "Boris" };
            leader.What_was_done();

        }

    }
}
