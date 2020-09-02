using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //First method(without function)
            Console.WriteLine("Enter a one-figure number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 9)
            {
                Console.WriteLine(n * n);
                i += 1;
            }

            //Second method(using function math.pow)
            for (i = 1; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(n, i));
            }
        }
    }
}
