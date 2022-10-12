using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class diagonal
    {
        static void Main(string[] args)
        {
            int[ , ] arr = new int[3, 3] { { 1, 2,3 }, { 4, 5,6}, { 7, 8,9} };
            int i ,j;
            int m =arr.GetLength(0);
            int   n =arr.GetLength(0);
            int sum = 0;
            Console.WriteLine("diagonal are:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(arr[i, j] + " ");
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine("Diagonal sum:" + sum);
        }   
    }
}
