
namespace Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// 抽像端口
    /// </summary>
    public abstract class Prototype
    {
        private string _id;

        //Gets id
        public string Id { get { return this._id; } }

        // Constructor
        public Prototype(string id)
        {
            this._id = id;
        }

        //等一下才要實作的抽象方法
        public abstract Prototype Clone();
    }

    #region 實例化的Prototype
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype1 : Prototype
    {
        // Constructor
        public ConcretePrototype1(string id):base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// B 'ConcretePrototype' class 
    /// </summary>
    public class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
    #endregion
}
