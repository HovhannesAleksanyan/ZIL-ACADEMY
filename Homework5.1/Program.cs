using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number(1-7)");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("The first day of the  week is Monday");
                    break;
                case 2:
                    Console.WriteLine("The second day of the week is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The third day of the week is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The forth day of the week is Thursday");
                    break;
                case 5:
                    Console.WriteLine("The fifth day of the week is Friday");
                    break;
                case 6:
                    Console.WriteLine("The sixth day of the week is Saturday");
                    break;
                case 7:
                    Console.WriteLine("The seventh day of the week is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}
