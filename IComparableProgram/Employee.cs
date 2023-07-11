using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableProgram
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        
    }
    public class SalaryComparison : IComparable<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if(e1.Salary < e2.Salary)
            {
                return -1;

            }
            else if(e1.Salary > e2.Salary) 
            {
                return 1;
            }
            else { return 0;}
        }

        public int CompareTo(Employee other)
        {
            throw new NotImplementedException();
        }
    }
}

