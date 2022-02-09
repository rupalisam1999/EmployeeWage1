using System;

namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else if (empCheck == 1)
            {
                Console.WriteLine("Employee is partial present");
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }
        }
    }
}
            