using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Model for handling cooling on the AC
     */
    public class CoolingManager : IAirConditioner
    {
        private readonly double _temperature;

        /*
         * Construct manager and take temperature as param
         */
        public CoolingManager(double temperature)
        {
            _temperature = temperature;
        }

        /*
         * Implementing the interface method for cooling
         */
        public void Operate()
        {
            Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
        }
    }
}
