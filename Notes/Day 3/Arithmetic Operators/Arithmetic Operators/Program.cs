using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a % b}");
            Console.WriteLine($"Add: {a + b}");
            Console.WriteLine($"Subtract: {a - b}");
            Console.WriteLine($"Multiply: {a * b}");
            Console.WriteLine(5f/ 2);
            int c = 5;
            Console.WriteLine($"Increment: {++c}");
            Console.WriteLine($"Decrement: {c--}");
            Console.WriteLine($"Decrement: {c++}");
            Console.WriteLine($"Decrement: {--c}");
            int d = 10;
            Console.WriteLine(d++);
            Console.WriteLine(++d);
        }
    }
}
