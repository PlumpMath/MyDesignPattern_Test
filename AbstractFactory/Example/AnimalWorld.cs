using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example
{
    /// <summary>
    /// The 'Client' class 
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;

        private Carnivore _carnivore;

        //Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();

            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
