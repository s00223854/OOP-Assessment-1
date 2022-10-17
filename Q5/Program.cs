using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salary = 50000;
            double inflation = 0.10;

            //Console.WriteLine($"new salary is {}" );
            InflationIncrease(salary, inflation);
            
        }

        static double InflationIncrease(int salary, double inflation)
        {

            int newSalary = (int)(salary * inflation);

            Console.WriteLine($"new salary is {newSalary + salary}");

            return newSalary;
        }
    }
}
