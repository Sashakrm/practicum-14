using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func()
        {
            int x = 0;
            while (x<=4)
            {
                Console.WriteLine("Привет");
                x++;
            }
        }
    }
}
