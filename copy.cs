using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthaday
{
    internal class copy
    {
        private string name;
        private int age;
        public copy(copy cop)
        {
            name = cop.name;
            age = cop.age;

        }
        public copy(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string details
        {
            get
            {
                return "the age of"  + name +  "is"  + age.ToString();

            }
        }
    }
    class Progress
    {
        static void Main(string[] args)
        {

            copy cop1 = new copy("maya", 23);
            copy cop2 = new copy(cop1);
            Console.WriteLine(cop2.details);
            Console.ReadLine();
        }
    }
}
