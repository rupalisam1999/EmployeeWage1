using System;

namespace EmployeeWage1
{
    class Program
    {




        static void Main(string[] args)
        {
       IComputeEmpWage empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}