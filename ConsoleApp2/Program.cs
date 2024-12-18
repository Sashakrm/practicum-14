using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n= ");
            Cicle(n);
            Console.Read();
        }
        static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        static void Cicle(int n)
        {
            int x = 1;
            while (x <= n)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
