using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HOmewrok7
{
    class Program
    {static void Task6()
        {
            Console.WriteLine("Enter two numbers");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(B - A + 1);
        }
        static void Task7()
        {
            Console.WriteLine("Enter two numbers");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void TAsk8()
        {
            Console.WriteLine("Enter two numbers");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            for(int i = A; i <= B; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static void Task9()
        {
            Console.WriteLine("Enter a anumber");
            double N = Double.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= N; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
        }
    }
}
