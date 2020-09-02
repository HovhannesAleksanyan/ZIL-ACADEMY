using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a natural number");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i <= number; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
