using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Class to build position section of Eployee
     */
    public class EmployeePositionBuilder : EmployeeInfoBuilder
    {
        public EmployeePositionBuilder AtPosition(string position)
        {
            employee.Position = position;
            return this;
        }
    }
}
