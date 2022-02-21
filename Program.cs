using System;

namespace EmployeeWage1
{
    class Program
    {




        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage("Dmart", 12, 6, 20, 90, 20);
             employeeWage.ComputeEmpwage();
            Console.WriteLine(employeeWage.ToString());
           
        }
    }
}