using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// the 'Client' class. Interaction environment for the products.
    /// </summary>
    public class Client
    {
        private AbstractProductA _abstractProductA;

        private AbstractProductB _abstractProductB;

        //Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();

            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
        
    }
}
