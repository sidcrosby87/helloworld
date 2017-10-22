using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Method(string arg)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arg);
            }
        }

        static void Main(string[] args)
        {
            string someString = "Hello world";
            Method(someString);
        }
    }
}
