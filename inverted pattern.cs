using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class inverted_pattern
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y > x; y--)
                {
                    Console.Write(" ");

                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
