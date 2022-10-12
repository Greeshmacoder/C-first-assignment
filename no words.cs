using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_work
{
    internal class no_words
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            string str = "Hello Girl";
            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                {
                    b++;
                }
                a++;

            }
            Console.WriteLine(" number of words in a string:{0}", b);
            Console.ReadLine();
        }
    }
}
