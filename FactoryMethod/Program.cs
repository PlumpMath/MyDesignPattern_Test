using FactoryMethod.Example;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main1(string[] args)
        {
            //An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();//此產出產品A
            creators[1] = new ConcreteCreatorB();//此產出產品B

            //Iterate over creators and create products
            int i = 0;
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Blue + (i++);
                Console.WriteLine("Create {0}", product.GetType().Name);

            }

            Console.ReadKey();
        }

        static void Main()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
