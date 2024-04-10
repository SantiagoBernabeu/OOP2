using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
  
    internal class Program
    {
        public static int Sum(int N)
        {
            int sum = 0;
            while (N != 0) { sum += N; N--; }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write($"Напиши число: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сбора на числата е: {Sum(n)}");
        }
    }
}
