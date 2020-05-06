using System;
using System.Collections.Generic;

namespace BuilderDesign
{
    /*
     * Demonstrates the use of the fluent builder design pattern
     */
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create list of products and populate it
             */
            var products = new List<Product>
            {
                new Product { Name = "Monitor", Price = 199.98 },
                new Product { Name = "Keyboard", Price = 20.22},
                new Product { Name = "Mouse", Price = 10.99}
            };

            /*
             * Create builder logic with product list as argument and 
             * director with builder logic as argument then build the report
             */
            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            /*
             * Print the report
             */
            var report = builder.GetReport();
            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
