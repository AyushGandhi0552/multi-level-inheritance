using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_level_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeCountry country = new EmployeeCountry();
            Employeeaddress employeeaddress = new Employeeaddress();
            Employee employee = new Employee();
            employee.input();
            employee.output();
            Console.ReadKey();
        }
    }
}
