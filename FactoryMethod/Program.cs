using System;

namespace FactoryMethod
{
    class Program
    {
        /*
         * Demonstrate the use of factory method with chaining syntax
         */
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 22.5)
                .Operate();
        }
    }
}
