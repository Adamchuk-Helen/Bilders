using System;

namespace HW5
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            //            Реалізувати класи House, Basement, Walls, Door, Window, Roof, Worker, TeamLeader, 
            //                Team та інтерфейси IWorker, IPart.
            //Всі частини будинку повинні бути класами та реалізувати 
            //                інтерфейс IPart, для робочих і бригадира 
            //                надається базовий інтерфейс IWorker.
            //Бригада будівельників(Team) будує будинок(House). 
            //                Будинок складається з фундаменту(Basement), 
            //                стін(Wall), вікон(Window), дверей(Door), даху(Roof).
            //Згідно проекту, в будинку повинно бути 1 фундамент,
            //                4 стіна, 1 двері, 4 вікна і 1 дах.
            //Врахуйте також, що двері бувають різні: скляні, 
            //                металеві, дерев’яні, профільні тощо. 
            //                Фундамент також буває різного виду: 
            //            стрічковий, збірний, стовпчастий, суцільний, 
            //                зварний тощо. Реалізувати це за допомогою 
            //                перелічувального типу(enum).
            //Бригада починає роботу, і будівельники послідовно будують 
            //            будинок, починаючи з фундаменту.Кожен будівельник 
            //            не знає наперед, на чому завершився попередній етап 
            //            будівництва, тому він "перевіряє", що вже побудовано і продовжує роботу.
            //Якщо в гру вступає бригадир (TeamLeader), він не будує, 
            //                а формує звіт, що вже побудовано
            //                і яка частина роботи виконана.
            //В кінцевому рахунку на консоль виводиться повідомлення,
            //що будівництво будинку завершено і відображається "малюнок будинку” (циклами). 

            
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
