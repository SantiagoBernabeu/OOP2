using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{month} има {System.DateTime.DaysInMonth(2024, month)}");

            DateTime clock = DateTime.Now;
            Console.WriteLine(clock);
        }
    }
}
