﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            BMM(x, y);
            KMM(x, y);
        }

        private static void BMM(int x, int y)
        {
            int i, min, bmm = 1;

            min = x;

            if (min > y)
            {
                min = y;
            }

            for (i = 1; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    bmm = i;
                }
            }
            Console.WriteLine(bmm);
        }

        private static void KMM(int x, int y)
        {
            int i = 1, max, min;

            max = x;
            min = y;

            if (y > max)
            {
                max = y;
                min = x;
            }

            while (true)
            {
                max *= i;
                if (max % min == 0)
                {
                    Console.WriteLine(max);
                    break;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}