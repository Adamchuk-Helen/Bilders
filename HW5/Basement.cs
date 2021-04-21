using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    
    public class Basement :  IPart
    {
        public static int counter_Basement = 0;
        public enum Type
        {
            tape = 1, prefabricated, columnar, solid, welded
        }
        public Type typeBasement { get; set; }

        public Basement(Type typeBasement = Type.tape)
        {
            this.typeBasement = typeBasement;
            counter_Basement++;
        }

        public void What_Done(Worker w)
        {
            Console.WriteLine($"\nWhat type of basement to build?" +
                $" \n1. tape, \n2. prefabricated, \n3. columnar, \n4. solid, \n5. welded");
            Type t = (Type)Enum.Parse(typeof(Type), Console.ReadLine());


            switch (t)
            {
                case Type.tape:
                    {
                        this.typeBasement = Type.tape;
                        break;
                    }
                case Type.prefabricated:
                    {
                        this.typeBasement = Type.prefabricated;
                        break;
                    }
                case Type.columnar:
                    {
                        this.typeBasement = Type.columnar;
                        break;
                    }
                case Type.solid:
                    {
                        this.typeBasement = Type.solid;
                        break;
                    }
                case Type.welded:
                    {
                        this.typeBasement = Type.welded;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error of choose");
                        break;
                    }

            }
           


            Console.WriteLine($"\nWorker {w.name} built {typeBasement} basement");
        }
      
    }

}
