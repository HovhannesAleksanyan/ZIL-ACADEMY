using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Firstmethod(if/else)
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 || num % 3 == 0)
                Console.WriteLine("Number is divisible by 2 or 3");
            else
                Console.WriteLine("Number is divisible neither by 2 nor by 3");
            #endregion

            #region Second method(ternary)
            Console.WriteLine(num % 2 == 0 || num % 3 == 0 ? "NUmber is divisible by 2 or 3" : "Number is divisible neither by 2 nor by 3");
            #endregion
        }
    }
}
