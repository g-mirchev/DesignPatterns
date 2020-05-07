using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Absrtract class for builder elements
     */
    public abstract class EmployeeBuilder
    {
        protected Employee employee;

        /*
         * Create new employee
         */
        public EmployeeBuilder()
        {
            employee = new Employee();
        }

        /*
         * Return employee
         */
        public Employee Build() => employee;
    }
}
