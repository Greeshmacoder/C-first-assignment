using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthaday
{
    internal class Constructor
    {
        int a, b;
        public Constructor()
        {
            a = 1;
            b = 2;
        }
        static void Main(string[] args)
        {
            Constructor obj = new Constructor();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();

        }

    }
}
