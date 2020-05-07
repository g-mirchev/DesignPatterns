using System;
using System.Collections.Generic;
using System.Text;

namespace FacetedBuilder
{
    /*
     * Logic for building car describtion info
     */
    public class CarInfoBuilder : CarBuilderFacade
    {
        /*
         * Create car info section taking car as parameter
         * and instantiating it through inheritance
         */
        public CarInfoBuilder(Car car)
        {
            Car = car;
        }

        /*
         * Build the car type
         */
        public CarInfoBuilder WithType(string type)
        {
            Car.Type = type;
            return this;
        }

        /*
         * Build the car color
         */
        public CarInfoBuilder WithColor(string color)
        {
            Car.Color = color;
            return this;
        }

        /*
         * Build the number of doors for the car
         */
        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            Car.NumberOfDoors = number;
            return this;
        }
    }
}
