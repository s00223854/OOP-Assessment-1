using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2
            string userPlace;
            int discount;
            int fee = 100;


            Console.WriteLine("Enter your place of residence");
            userPlace = Convert.ToString(Console.ReadLine());

            

            if (userPlace == "sligo")
            {
                discount = 30;
            }
            if (userPlace == "ireland")
            {
                discount = 20;
            }
            if (userPlace == "europe")
            {
                discount = 10;
            }
            else
                discount = 0;

            Console.WriteLine("Your fee is: ",discount - fee);

        }

    }
}
