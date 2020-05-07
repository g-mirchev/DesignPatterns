using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Class to build position section of Eployee inherits employee object from EmployeeInfoBuilder
     * and returns generic type with restriction of that type being EmployeePositionBuilder type.
     * This supports the fluent builder interface approach
     */
    public class EmployeePositionBuilder<T> : EmployeeInfoBuilder<EmployeePositionBuilder<T>> where T : EmployeePositionBuilder<T>
    {
        public T AtPosition(string position)
        {
            employee.Position = position;
            return (T)this;
        }
    }
}
