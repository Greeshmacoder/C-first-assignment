using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Day
{
    internal class negative
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 2, -3, -5, -6, 3, 9, -8 };
            int[] arr2;
            int i;
            Console.WriteLine("List of negative elements");
            for(i=0;i< arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);

                }
                arr2 = arr.CopyTo(arr2);
            }
           
        }
    }
}
