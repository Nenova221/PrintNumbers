using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing
{
    public class PrintNumbers
    {
        public static int PrintNumbersToN(int n, string expected)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNumbersToN(n);
        }
    }
}
