using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Model for handling warming on AC
     */
    public class WarmingManager : IAirConditioner
    {
        private readonly double _temperature;

        /*
        * Construct manager and take temperature as param
        */
        public WarmingManager(double temperature)
        {
            _temperature = temperature;
        }

        /*
        * Implementing the interface method for warming
        */
        public void Operate()
        {
            Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees");
        }
    }
}
