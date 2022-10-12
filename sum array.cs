using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class sum_array
    {
        static void Main(string[] args)
        {
            int sum;
            int[] num = new int[5] { 1, 3, 4, 2, 5 };
            sum = num.Sum();
            Console.WriteLine(sum);
        }
    }
}
