using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumsWithNoTempVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give two numbers: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The initial numbers are: {a} & {b}\n");

            a = a + b;
            b = a - b;
            a = a - b;

            
            Console.WriteLine($"After swapping the numbers are: {a} & {b}");

            Console.ReadKey();
        }
    }
}
