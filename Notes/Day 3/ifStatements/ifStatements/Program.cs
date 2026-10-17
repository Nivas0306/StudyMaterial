using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                Console.WriteLine("This is true");
            }
            else
            {
                Console.WriteLine("This is false");
            }
            Console.WriteLine("if else lader");

            if (false)
            {
                Console.WriteLine("F1");
            }
            else if (true)
            {
                Console.WriteLine("F2");
            }
            else if (true)
            {
                Console.WriteLine("F3");
            }
        }

    }
}

