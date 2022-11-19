﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inventory, goal, profit;

            inventory = Convert.ToInt32(Console.ReadLine());
            goal = Convert.ToInt32(Console.ReadLine());
            profit = Convert.ToInt32(Console.ReadLine());

            Profit(inventory, goal, profit);
        }

        private static void Profit(int x, int y, int z)
        {
            int i = 1;

            while (true)
            {
                if ((x * (z / 100) * i) + x >= y)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    x += (x * (z / 100) * i);
                    i++;
                }
            }
        }
    }
}