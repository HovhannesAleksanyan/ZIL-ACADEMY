﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a natural number");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(number, i));
            }
        }
    }
}