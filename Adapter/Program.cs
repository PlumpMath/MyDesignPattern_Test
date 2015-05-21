using Adapter.Example;
using System;

namespace Adapter
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }

        static void Main()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            //水
            Compound water = new RichCompound("Water");
            water.Display();

            //苯
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            //乙醇
            Compound ethanol = new RichCompound("Ethanol"); ;
            ethanol.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
