using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Func();
            Console.Read();
            
        }
        static void Func()
        {
            for (int x = 1; x <= 25; x++) 
            {
                Console.Write("@");
            }
        }
    }
}
