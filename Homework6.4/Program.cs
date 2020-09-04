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
           Console.WriteLine("Enter a one-figure number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine(Math.Pow(n, i));
            }
        }
    }
}
