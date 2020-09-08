using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HOmewrok7
{
    class Program
    {
        static void Task6()
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
            for (int i = A; i <= B; i++)
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
        static void Task10()
        {
            Console.WriteLine("Enter a number");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; N + i <= 2 * N; i++)
            {
                sum += (N + i) * 2;
            }
            Console.WriteLine(sum);
        }
        static void Task11()
        {
            Console.WriteLine("Enter a number");
            double product = 1;
            double N = double.Parse(Console.ReadLine());
            for (double i = 1.1; i <= 1 + (N / 10); i += 0.1)                             //mi hat pakasa vercnum
            {
                product = product * i;
            }
            Console.WriteLine(product);

        }
        static void TAsk12()
        {
                                                                    //chi stacvel
        }
        static void TAsk13()
        {
            Console.WriteLine("Enter a number");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 2 * N - 1; i += 2)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
        static void TAsk14()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            if ((sum * 2) == n)                                   //chi ashxatum
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        static void Task15()
        {
                                                               //chi stacvel
        }
        static void TAsk16()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            int product = 1;
            while (n != 0)
            {
                product *= n % 10;
                n /= 10;
            }
            string k = n.ToString();
            int i = k.Length;
            Console.WriteLine("Sum of digits is{0}", sum);
            Console.WriteLine("Product of digits is {0}", product);
            Console.WriteLine("NUmber of digits is {0}", i);
        }
        static void Task17()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int smallestnumber = 10;
            while (n != 0)
            {
                int digit = n % 10;
                if (digit % 2 != 0 && digit < smallestnumber)
                {
                    smallestnumber = digit;
                }
                n /= 10;
            }
            Console.WriteLine(smallestnumber);
        }
        
        static void TASk18()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n > 0)
            {
                if (n % 10 > 4 && (n % 10) % 2 == 1)
                {
                    sum += n % 10;
                }
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        static void TAsk19()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            while (n > 0)
            {
                if (n % 10 < 7 && (n % 10) % 2 == 0)
                {
                    product *= n % 10;
                }
                n /= 10;
            }
            Console.WriteLine(product);
        }
        static void TAsk20()
        {
            int largestnumber = 0;
            int smallestnumber = 10;
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                int digit = n % 10;
                if (digit > largestnumber)
                {
                    largestnumber = digit;
                }
                if (digit < smallestnumber)
                {
                    smallestnumber = digit;
                }
                n /= 10;
            }
            Console.WriteLine(Math.Pow((largestnumber - smallestnumber),2));
        }
        static void TAsk21()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void task22()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
        static void Taask23()
        {

        }
        static void TAsk24()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            while (n > 3)
            {
                n = n / 3;
            }
            if (n % 3 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        static void TAsk25()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int k = (int)(Math.Log(n) / Math.Log(2));
            Console.WriteLine(Math.Pow(2, k));
        }
        static void TAsk26()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int k = (int)(Math.Log(n) / Math.Log(2));
            Console.WriteLine(Math.Pow(2, k + 1));
        }
        static void TAsk27()
        {

        }

        static void Main(string[] args)
        {
        }
    }
}
