using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /*
     * Abstract model for AC manager factories
     */
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
