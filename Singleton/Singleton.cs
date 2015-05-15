
namespace Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class Singleton
    {
        private static Singleton _singleton;

        /// <summary>
        /// lock object
        /// </summary>
        private static object clock = new object();

        // Constructor is 'protected'
        protected Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_singleton == null)
            {
                Singleton._singleton = new Singleton();
            }

            // Note: this is thread safe.
            //if (_singleton == null)
            //    lock (clock)
            //    {
            //        if (_singleton == null)
            //        {
            //            Singleton._singleton = new Singleton();
            //        }
            //    }
            return Singleton._singleton;
        }
    }
}
