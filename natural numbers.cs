using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class natural_numbers
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("enter the  first 10 digit numnbers");
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine( i);
                sum = sum + i;
            }
            Console.WriteLine("sum of numbers:" + sum);
            Console.ReadLine();
        }
    }
}
