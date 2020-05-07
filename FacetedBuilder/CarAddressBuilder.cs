using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    /*
     * Logic for building car manufacturer info
     */
    public class CarAddressBuilder : CarBuilderFacade
    {
        /*
         * Creates the manufacturing section of the car taking a car as parameter
         * and instantiating it through inheritance
         */
        public CarAddressBuilder(Car car)
        {
            Car = car;
        }

        /*
         * Build the car city
         */
        public CarAddressBuilder InCity(string city)
        {
            Car.City = city;
            return this;
        }

        /*
         * Build the car address
         */
        public CarAddressBuilder AtAddress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}
