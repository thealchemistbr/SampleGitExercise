using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math;

namespace Mat
{
    class MathConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Console 1.0");
            Console.WriteLine();

            Console.WriteLine("Add: ", Operations.Add(1, 2));
            Console.WriteLine("Subtract: ", Operations.Subtract(1, 2));

            Console.ReadLine();
        }
    }
}
