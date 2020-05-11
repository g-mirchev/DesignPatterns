using System;
using System.Collections.Generic;
using System.Text;

namespace FluentBuilderRecursiveGenerics
{
    /*
     * Creating salary builder for employee object inherited from position builder implementing
     * generic recursive inheritence
     */
    public class EmployeeSalaryBuilder<T> : EmployeePositionBuilder<EmployeeSalaryBuilder<T>> where T : EmployeeSalaryBuilder<T>
    {
        public T WithSalary(double salary)
        {
            employee.Salary = salary;
            return (T)this;
        }
    }
}
