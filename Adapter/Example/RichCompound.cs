using System;

namespace Adapter.Example
{
    /// <summary>
    /// The 'Target' class
    /// 合成物
    /// </summary>
    public class Compound
    {
        protected string _chemical;//化學藥品
        protected float _boilingPoint;//沸點
        protected float _meltingPoint;//溶點
        protected double _molecularWeight;//分子重量
        protected string _molecularFormula;//分子配方


        // Constructor
        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }

    /// <summary>
    /// The 'Adapter' class
    /// 加強版的合成物
    /// </summary>
    public class RichCompound : Compound
    {
        private ChemicalDatabank _bank = new ChemicalDatabank();

        //Constructor
        public RichCompound(string chemical)
            : base(chemical)
        {

        }

        /// <summary>
        /// 改寫顯示方式
        /// </summary>
        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }

    /// <summary>
    /// The 'Adaptee' class
    /// 
    /// </summary>
    public class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point 溶點
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point 沸點
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        /// <summary>
        /// 取得分子式
        /// </summary>
        /// <param name="compound">分子式</param>
        /// <returns></returns>
        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        /// <summary>
        /// 取得分子重量
        /// </summary>
        /// <param name="compound"></param>
        /// <returns></returns>
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}

