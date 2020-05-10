using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Model for cooling manager factory
     */
    public class CoolingFactory : AirConditionerFactory
    {
        /*
         * Create and return new coling manager with the param temperature as arg
         */
        public override IAirConditioner Create(double temperature) => new CoolingManager(temperature);
    }
}
