using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    /*
     * Facade for the car builder instantiates the car object
     * to be inherited by other builders
     */
    public class CarBuilderFacade
    {
        protected Car Car { get; set; }

        /*
         * Instantiate the car object
         */
        public CarBuilderFacade()
        {
            Car = new Car();
        }

        /*
         * Return the car object
         */
        public Car Build() => Car;
    }
}
