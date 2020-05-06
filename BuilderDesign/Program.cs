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
            var products = new List<Product>
            {
                new Product { Name = "Monitor", Price = 199.98 },
                new Product { Name = "Keyboard", Price = 20.22},
                new Product { Name = "Mouse", Price = 10.99}
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);

            Console.ReadKey();
        }
    }
}
