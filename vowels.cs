using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Day
{
    internal class vowels
    {
        static void Main(string[] args)
        {
            int i, v , len;
            string str = "Greeshma0";
            v = 0;
            
            
            len = str.Length;
            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == '0' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    v++;

                }
               
                
                    
                
            }
                    Console.WriteLine("number of vowels in string:{0}", + v);
                Console.ReadLine();
                
            
            

        }
    }
}
