using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    public class Door: IPart
    {
        public static int counter_Door = 0;
        public Door() { counter_Door++; }
        public enum TypeDoor
        {
            glass = 1, metal, wooden, profile
        }

        public TypeDoor typeDoor { get; set;}

        public Door(TypeDoor typeDoor = TypeDoor.glass)
        {
            this.typeDoor = typeDoor;
        }

        public void What_Done(Worker w)
        {
            Console.WriteLine($"\nWhat type of door to insert?" +
               $" \n1. glass, \n2. metal, \n3. wooden, \n4. profile,");
            TypeDoor t = (TypeDoor)Enum.Parse(typeof(TypeDoor), Console.ReadLine());


            switch (t)
            {
                case TypeDoor.glass:
                    {
                        this.typeDoor = TypeDoor.glass;
                        break;
                    }
                case TypeDoor.metal:
                    {
                        this.typeDoor = TypeDoor.metal;
                        break;
                    }
                case TypeDoor.profile:
                    {
                        this.typeDoor = TypeDoor.profile;
                        break;
                    }
                case TypeDoor.wooden:
                    {
                        this.typeDoor = TypeDoor.wooden;
                        break;
                    }
 
                default:
                    {
                        Console.WriteLine("Error of choose");
                        break;
                    }

            }


            Console.WriteLine($"\nWorker {w.name} insert {typeDoor} door");
        }
    }
    
}
