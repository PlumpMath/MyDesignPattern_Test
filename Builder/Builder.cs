using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// 藉由此物件之手執行建造者物件的複雜步驟
    /// </summary>
    public class Director
    {
        // Builder uses a complex series of steps
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    #region Builder include Product and ConcreteBuilder - 抽象建造者內包含(實作的建造者和建造者內包含(產品和處理產品的方法))
    /// <summary>
    ///  The 'Builder' abstract class
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();
    }

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartA");
        }

        public override void BuildPartB()
        {
            _product.Add("PartB");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {

        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("PartX");
        }

        public override void BuildPartB()
        {
            _product.Add("PartY");
        }

        public override Product GetResult()
        {

            return _product;
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Product
    {
        private List<string> _parts = new List<string>();

        /// <summary>
        /// 資料加入集合
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }

        /// <summary>
        /// 顯示集合內的資料
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");

            foreach (string part in this._parts)
            {
                Console.WriteLine(part);
            }
        }
    }
    #endregion

}
