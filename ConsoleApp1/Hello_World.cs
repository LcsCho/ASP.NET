using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hello_World
    {
        static void Main()
        {
            AA var = new AA();
            var.PrintHello("Hello World!");
        }
    }

    class AA
    {
        public void PrintHello(string str)
        {
            Console.WriteLine(str);
        }
    }
}
