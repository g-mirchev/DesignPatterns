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

        /*
         * Create the info and address sections of the car
         * passing the current Car as argument
         */
        public CarInfoBuilder Info => new CarInfoBuilder(Car);
        public CarAddressBuilder Built => new CarAddressBuilder(Car);
    }
}
