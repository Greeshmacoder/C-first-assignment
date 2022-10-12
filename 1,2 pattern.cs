using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class _1_2_pattern
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <=5 ; x++)
            {
                for (y = 1; y <= x; y++)
                {
                 
                    Console.Write(y);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
