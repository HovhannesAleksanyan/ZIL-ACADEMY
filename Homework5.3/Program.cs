using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First method(if/else)
            Console.WriteLine("Enter a number");
            double num = double.Parse(Console.ReadLine());
            if (num % 1 == 0 && num % 2 == 1)
                Console.WriteLine("Number is natural and is an odd number");
            else if (num % 1 != 0)
                Console.WriteLine("Number is not a natural number");
            #endregion

            #region Second method(ternary)
            Console.WriteLine(num % 1 != 0 ? "Number is not a natural number" : "NUmber is a natural number");
            #endregion
        }
    }
}
