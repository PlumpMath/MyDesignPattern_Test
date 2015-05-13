using System;
using System.Collections.Generic;

namespace Builder.Example
{
    /// <summary>
    /// The 'Builder' abstract class
    /// 定義操作車輛物件(產品)的抽象操作者
    /// </summary>
    public abstract class VehicleBuilder
    {
        //product
        protected Vehicle vehicle;

        //Gets vehicle instance
        public Vehicle Vehicle { get { return vehicle; } }

        //Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    #region 實作抽象建造者物件(很多種)
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// 重型摩托車建造者
    /// </summary>
    public class MotorCycleBuilder : VehicleBuilder
    {
        //Constructor
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        #region 操作方法
        public override void BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
        #endregion
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// 汽車建造者
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        //Constructor
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }

        #region 操作方法
        //
        public override void BuildFrame()
        {
            vehicle["frame"] = "Car Frame";
        }
        //建造引擎
        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }
        //建造輪子
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        //建造門
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
        #endregion
    }

    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// 小型摩托車建造者
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        //Constructor
        public ScooterBuilder()
        {
            vehicle = new Vehicle("Scooter");
        }

        #region 操作方法
        public override void BuildFrame()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "50 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
        #endregion
    }
    #endregion
    /// <summary>
    /// The 'Product' class
    /// 車輛
    /// </summary>
    public class Vehicle
    {
        private string _vehicleType;

        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        //Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get
            {
                return _parts[key];
            }
            set
            {
                //this._parts.Add(key, value);//下面方式也等同增加字典集合
                this._parts[key] = value;
                
            }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}
