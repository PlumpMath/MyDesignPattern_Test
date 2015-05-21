using System;

namespace Adapter
{
    /// <summary>
    /// The 'Target' class
    /// 原本的目標物件
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }

    /// <summary>
    /// The 'Adapter' class
    /// 繼承了原始的目標物件,也執行原始目標物件原來定義的方法
    /// 但是加入另一個要執行的物件並改寫了內部的執行邏輯(執行令一個加入物件的方法)
    /// 不改變原始目標物件但又可執行另一個新物件的方法,前提是目標物件的方法可覆寫(virtual)
    /// 類似中介調配器
    /// </summary>
    public class Adapter : Target
    {
        //加上要指定執行的介接物件
        private Adaptee _adaptee = new Adaptee();

        /// <summary>
        /// 覆寫原本物件的執行內容
        /// </summary>
        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            _adaptee.SpecificRequest();
        }
    }

    /// <summary>
    /// the 'Adaptee' class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Adaptee SpecificRequest()");
        }
    }
}
