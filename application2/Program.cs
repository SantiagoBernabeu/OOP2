using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application2
{
    internal class Program
    {
        public static bool IsPrime(int N)
        {
            if (N > 1)
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0) return false;
                }
                else return false;
            return true;
        }
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
    }
}
