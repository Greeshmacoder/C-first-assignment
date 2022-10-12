using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class sort
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            
            Console.WriteLine("enter the array elemant:");
            for ( int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("sorted elements:");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}
