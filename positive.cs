using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class positive
    {
        static void Main(string[] args)

        {
            int a;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("the number is postive");
            }
            else
            {
                Console.WriteLine("the number is negative");
            }
        }
    }
}
