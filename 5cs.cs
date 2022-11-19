using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            SQRT(n);
        }

        private static void SQRT(int n)
        {
            Console.WriteLine(Math.Sqrt(n));
        }
    }
}