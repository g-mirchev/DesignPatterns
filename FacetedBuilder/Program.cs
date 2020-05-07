using System;

namespace FacetedBuilder
{
    /*
     * Demonstrate the use of faceted builder
     */
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
                .Info
                    .WithType("Mercedes-Benz")
                    .WithColor("Black")
                    .WithNumberOfDoors(5)
                .Built
                    .InCity("Stuttgart")
                    .AtAddress("Random Street 420")
                .Build();

            Console.WriteLine(car);
        }
    }
}
