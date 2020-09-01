using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Firstmethod
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion

            #region Second method(Using third variable)
            int k = a;
            int j = b;
            Console.WriteLine(a = j);
            Console.WriteLine(b = k);
            #endregion
        }
    }
}
