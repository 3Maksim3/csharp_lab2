using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number and press enter: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number and press enter: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("result=" + Raz(a, b));
        }
        public static int Raz(int a, int b)
        {
            return (a - b);
        }

    }
}