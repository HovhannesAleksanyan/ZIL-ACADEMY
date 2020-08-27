using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 3.1


            int a = 77, b = 70;
            Console.WriteLine("a+b=" + (a + b));
            Console.WriteLine("a-b=" + (a-b));
            Console.WriteLine("a*b=" + (a * b));
            Console.WriteLine("a/b=" + (a / b));
            Console.WriteLine("a%b=" + (a % b));
            #endregion

             #region Homework 3.2
             byte k = 255;
              checked
              {
                  byte i =(byte)(k + 7);
              }
              unchecked
              {
                  byte o = (byte)(k + 7);
              }
                            #endregion

                #region Homework 3.3
                float f = 27.7f;
                float y = 25.5f;
                Console.WriteLine("f+y=" + (f + y));
                Console.WriteLine("f-y=" + (f - y));
                Console.WriteLine("f*y=" + (f * y));
                Console.WriteLine("f/y=" + (f / y));
                #endregion


        }
    }
}
