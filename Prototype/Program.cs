using Prototype.Example;
using System;

namespace Prototype
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Create two instances and clone each

            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            Console.WriteLine("Cloned: {0}", p1.Id);
            ConcretePrototype1 client1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", client1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            Prototype client2 = p2.Clone();
            Console.WriteLine("Cloned: {0}", client2.Id);

            Console.ReadKey();
        }

        static void Main()
        {
            
            ColorManager colorManager = new ColorManager();

            // Initialize with standard colors
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colorManager["angry"] = new Color(255, 54, 0);
            colorManager["peace"] = new Color(128, 211, 128);
            colorManager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color c1 = colorManager["red"].Clone() as Color;
            Color c2 = colorManager["peace"].Clone() as Color;
            Color c3 = colorManager["flame"].Clone() as Color;

            //列舉Enum型別的物件
            //string[] colors = Enum.GetNames(typeof(ConsoleColor));
            //foreach (string i in colors)
            //{
            //    Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), i);
            //    Console.WriteLine(i + ":" + (int)Enum.Parse(typeof(ConsoleColor), i));
            //}

            Console.ReadKey();
        }
    }
}
