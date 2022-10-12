using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class integers_equal
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Enter the first number");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            n = Convert.ToInt32(Console.ReadLine());
            if (m == n)
            {
                Console.WriteLine("the given numbers are equal");
            }
            else
            {
                Console.WriteLine("the given numbers are not equal");
                Console.ReadLine();
             }
        }
    }
}
