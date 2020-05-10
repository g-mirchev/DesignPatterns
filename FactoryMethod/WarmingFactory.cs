using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Model for warming manager factory
     */
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new WarmingManager(temperature);
    }
}
