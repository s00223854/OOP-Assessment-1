using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class Worker
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public Decimal HourlyRate { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Worker Name: {Name}");
            Console.WriteLine($"Worker Type: {Type}");
            Console.WriteLine($"Worker Hourly Rate: {HourlyRate}");
        }
    }
  
}
