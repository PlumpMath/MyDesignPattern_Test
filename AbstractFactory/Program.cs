using AbstractFactory.Example;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main1(string[] args)
        {
            //抽像工廠用途主要是提供一個介面創建一個相關的物件但不指定具體的類別
            //宣告一個抽象工廠變數用來接實作專門產出產品1的產線1
            AbstractFactory factory1 = new ConcreteFactory1();
            //弄一個使用者
            Client client1 = new Client(factory1);
            client1.Run();

            //宣告一個抽象工廠變數用來接實作專門產出產品2的產線2
            AbstractFactory factory2 = new ConcreteFactory2();
            //弄一個使用者
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }

        static void Main()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
 
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
 
            // Wait for user input
            Console.ReadKey();
        }
    }
}
