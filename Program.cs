using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("largest is:" + a);
                }

                else
                {
                    Console.WriteLine("largest is:" + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("largest is :" + b);
                }

                else
                {
                    Console.WriteLine("largest is :" + c);
                }

            }
        }
    }
}
    

