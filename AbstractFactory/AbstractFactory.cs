using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    #region Factory - 抽像工廠用途主要是提供一個介面創建一個相關的物件但不指定具體的類別
    /// <summary>
    /// the 'AbstractFactory' abstract class
    /// 有抽象界面的工廠,有用來產出產品A或產品B的宣告(declare)方法
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }

    /// <summary>
    /// the 'ConcreteFactory1' class
    /// (產線1)用來實現抽象工廠要產出的產品1
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    /// the 'ConcreteFactory2' class
    /// (產線2)用來實現抽象工廠要產出的產品2(其實只要是繼承抽象產品x的都可以return)
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    #region AbstractProductA - 產品A相關
    /// <summary>
    /// the 'AbstractProductA' abstract class
    /// 抽象的產品A(即產品A的原型定義)
    /// </summary>
    public abstract class AbstractProductA
    {

    }

    /// <summary>
    /// 依產品A的原型產出產品A1(擁有產品A的原型或初始設定)
    /// </summary>
    public class ProductA1 : AbstractProductA
    {

    }
    public class ProductA2 : AbstractProductA
    {

    }
    #endregion

    #region AbstractProductB - 產品B相關
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
    #endregion
    #endregion
}
