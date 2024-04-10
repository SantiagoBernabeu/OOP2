using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application5
{
    internal class Program
    {
        public static bool IsLeap(int year)
        {
            if((year % 4 ==0  && year%100 != 0) || year % 400 == 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (IsLeap(n)) Console.WriteLine("leap");
            else Console.WriteLine("Not leap");
        }
    }
}
