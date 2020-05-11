using System;

namespace Singleton
{
    /*
     * Demonstrates the use of singleton design pattern which is a rarely used
     * design pattern in which an object has to be created only once and made thread safe
     */
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("London"));
        }
    }
}
