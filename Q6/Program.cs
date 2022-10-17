using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.Name = "Tom";
            worker1.Type = "Plumber";
            worker1.HourlyRate = 15;
            Worker worker2 = new Worker();
            worker2.Name = "Jo";
            worker2.Type = "Electrician";
            worker2.HourlyRate = 20;

            worker1.DisplayInfo();
            worker2.DisplayInfo();

        }
    }
}
