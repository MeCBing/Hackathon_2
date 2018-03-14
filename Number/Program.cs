﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintfNumber();
            Console.ReadLine();
        }

        private static void PrintfNumber()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 != 0 || i % 5 != 0)
                {
                    Console.WriteLine($"{i.ToString()}  {i}/3 = {i / 3}...{i % 3}  |  {i}/5 = {i / 5}...{i % 5}");
                }
            }
        }
    }
}
