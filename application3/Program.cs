using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application3
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            decimal result = 0;
            for (int i = 0; i < input.Length; i++)
                result += Convert.ToDecimal(input[i]);
            Console.WriteLine(result);
        }
    }
}
