using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("String Interpolation Example");
            int age = 23;
            char Name = 'A';
            var Hight = 5.9;
            Console.WriteLine("With String Interpolation");
            Console.WriteLine($" Name: {Name}\n Age: {age}\n Height: {Hight}");
            Console.WriteLine("Without String Interpolation");
            Console.WriteLine(" Name: " + Name + "\n Age: " + age + "\n Height: " + Hight);
            Console.WriteLine(34.40M);

        }
    }
}
