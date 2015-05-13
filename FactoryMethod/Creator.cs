
namespace FactoryMethod
{
    #region 定義一個端口用於創建物件,但讓端口的子類別決定要實例(new)那個類別,因為需實作工廠方法而使得類別的實例化延遲到讓端口的子類別去做(所以可以自訂)
    /// <summary>
    /// The 'Creator' abstract class
    /// 抽象的建造者有產出抽象產品的方法
    /// </summary>
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// 實作抽象建造者的CreatorA有產出抽象產品的方法(內部再看要return啥產品,只要有繼承抽像產品,就好說好說)
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    /// <summary>
    /// B 'ConcreteCreator' class
    /// 另一個實作抽像建造者的CreatorB(方式同CreatorA)
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
    #endregion
}
