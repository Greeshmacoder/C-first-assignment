using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class Arraycount
    {
        static void Main(string[] args)
        {
            int e, o, i;
            int[] num = new int[5] { 1, 3, 7, 9, 4 };
            e = 0;
            o = 0;


            for (i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    e++;

                }
                else
                {
                    o++;
                }
            }
            Console.WriteLine("number of odd elements:{0}", o);
            Console.WriteLine("number of even elements:{0}", e);
        }
    }
}
