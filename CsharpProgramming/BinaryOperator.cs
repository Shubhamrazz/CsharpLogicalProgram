using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    public class BinaryOperator
    {
        public static void Operators()
        {
            int x = 5, y = 10, result;

            // Bitwise AND Operator
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);

            // Bitwise OR Operator
            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);

            // Bitwise XOR Operator
            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);
            
        }
    }
}
