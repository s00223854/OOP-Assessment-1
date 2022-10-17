using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assessment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userYear;

            Console.WriteLine("enter your year of birth");
            userYear = Convert.ToInt32(Console.ReadLine());

            if (userYear > 2004)
            {
                Console.WriteLine("access denied");
            }
            else if (userYear <= 2004 && userYear >= 1900)
            {
                Console.WriteLine("access granted");
            }
        }
    }
}
