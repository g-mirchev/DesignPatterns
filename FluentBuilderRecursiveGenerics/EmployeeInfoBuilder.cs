using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Class to build Name part of Employee
     */
    public class EmployeeInfoBuilder
    {
        protected Employee employee = new Employee();

        public EmployeeInfoBuilder SetName(string name)
        {
            employee.Name = name;
            return this;
        }
    }
}
