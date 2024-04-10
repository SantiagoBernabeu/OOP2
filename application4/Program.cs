using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace application4
{
    internal class Program
    {
        public static string Check(decimal[] euroArr, decimal[] usdArr)
        {
            string output = "";
            decimal euro_value = 1.95m;
            decimal usd_value = 1.80m;

            for (int i = 0; i < euroArr.Count(); i++)
                if (euroArr[i] * euro_value == usdArr[i] * usd_value) output += $"{euroArr[i]* euro_value} - {usdArr[i]* usd_value} : True\n";
                else output += $"{euroArr[i]* euro_value} - {usdArr[i] * usd_value} : False\n";
            return output;
        }
        public static bool IsEqual(decimal[] euroArr, decimal[] usdArr)
        {
            if(euroArr.Length != usdArr.Length) return false;

            decimal euro_value = 1.95m;
            decimal usd_value = 1.8m;

            decimal sum_eur = 0;
            decimal sum_usd = 0;

            for (int i = 0; i < euroArr.Count(); i++)
            {
                sum_eur += euroArr[i] * euro_value;
                sum_usd += usdArr[i] * usd_value;
            }

            if(sum_eur == sum_usd) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            decimal[] euroArr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal[] usdArr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

           /* string[] input_euroArr = Console.ReadLine().Split(' ');
            string[] input_usdArr = Console.ReadLine().Split(' ');

            decimal[] euroArr = new decimal[input_euroArr.Length]; // ne raboti - trqbva dobavqne na stoinosti
            decimal[] usdArr = new decimal[input_usdArr.Length];*/

            Console.WriteLine(Check(euroArr,usdArr));
            Console.WriteLine(IsEqual(euroArr,usdArr));
        }
    }
}
