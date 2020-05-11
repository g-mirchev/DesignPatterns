using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Represents API to build Employee object inherits from EmployeeSalaryBuilder and sets the
     * type for the recursive generic approach enabling fluent interface inheritance
     */
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {
        public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
    }
}
