using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Operations
    {
        /// <summary>
        /// Returns the sum os two integers
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns></returns>
        public static int Add (int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Returns the subtraction of two integers
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns></returns>
        public static int Subtract (int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Returns the product of a multiplied by b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply (int a, int b)
        {
            return a * b;
        }
    }
}
