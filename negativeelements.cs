using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class negativeelements
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 2, -3, -5, -6, 3, 9, -8 };
            int[] arr2 = new int[10]; ;
            int i,n;
            Console.WriteLine("List of negative elements");
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr2[i] = arr[i];
                    Console.WriteLine( arr2[i]);
                    

                }
            }
            Console.ReadLine();
          
            
       
            
            
                


                
            


        }
    }
}
