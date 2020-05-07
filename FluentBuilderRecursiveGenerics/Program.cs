using System;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Demonstrate the fluent builder pattern
     */
    class Program
    {
        static void Main(string[] args)
        {
            var employee = EmployeeBuilderDirector
                .NewEmployee
                .SetName("Gregg")
                .AtPosition("Software Developer")
                .WithSalary(3500)
                .Build();

            Console.WriteLine(employee);
        }
    }
}
