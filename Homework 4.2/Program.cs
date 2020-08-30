using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input as 4digit number");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10; //b-verji tivna
            int c = a - b;
            int d = c % 100;
            int e = d / 10;   //e-naxaverjin tivna
            int f = d + b;
            int g = a - f;
            int h = g % 1000;
            int i = h / 100;    //i-verjic errord tivna
            int j = a - h;
            int k = j / 1000; //k arajin tivna
            int result = b + e + i + k;
            Console.WriteLine("The result is" + result);
        }
    }
}


