using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_programs
{
    internal class odd_natural_numbers
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the odd numbers ");
            for (i = 1; i <= n; i++)
            {


                Console.WriteLine("{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }

                Console.WriteLine("sum of odd numbers between {0} terms : {1} :" , n, sum);
                Console.ReadLine();
            }
        }
    }

