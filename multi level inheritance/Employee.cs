using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_level_inheritance
{
    internal class Employee:Employeeaddress
    {
        public int employeeid;
        public string employeename;
        public void input() 
        {
            Console.WriteLine("Please Enter ID");
            ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter EmployeeId:");
            employeeid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Your Name:");
            employeename = Console.ReadLine();
            Console.WriteLine("Please Enter your Address:");
            Address1 = Console.ReadLine();
            Console.WriteLine("Please Enter your city:");
            City = Console.ReadLine();
            Console.WriteLine("Please Enter Your Postal Code:");
            PostalCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your region:");
            Region = Console.ReadLine();
        }
        public void output() 
        {
            Console.WriteLine("Id is:" + ID);
            Console.WriteLine("Name is:"+Name);
            Console.WriteLine("Employee id id:" + employeeid);
            Console.WriteLine("Employee Name is:" + employeename);
            Console.WriteLine("Your Address! is:" + Address1);
            Console.WriteLine("your City is:" + City);
            Console.WriteLine("Your Postal code is:"+PostalCode);
            Console.WriteLine("Your region is:" + Region);

        }
    }
}
