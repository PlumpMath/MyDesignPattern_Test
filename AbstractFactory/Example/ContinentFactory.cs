using System;

namespace AbstractFactory.Example
{
    #region 抽象工廠模式
    public abstract class ContinentFactory
    {
        /// <summary>
        /// 產生草食性動物
        /// </summary>
        /// <returns>草食性動物</returns>
        public abstract Herbivore CreateHerbivore();
        
        /// <summary>
        /// 產生肉食性動物
        /// </summary>
        /// <returns>肉食性動物</returns>
        public abstract Carnivore CreateCarnivore();
    }

    /// <summary>
    /// The 'ConcreteFactory1' class
    /// 非洲大陸工廠
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();// 角馬
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();// 獅子
        }
    }

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// 美洲大陸工廠
    /// </summary>
    public class AmericaFactory : ContinentFactory
    {

        public override Herbivore CreateHerbivore()
        {
            return new Bison();//野牛
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();//野狼
        }
    }
    
    #region 草食性動物
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    public abstract class Herbivore 
    {

    }

    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class Wildebeest : Herbivore
    {
    }

    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class Bison : Herbivore
    {

    }
    #endregion

    #region 肉食性動物
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
    #endregion

    #endregion
}
