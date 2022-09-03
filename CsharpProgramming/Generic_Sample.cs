using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    class Generic_Sample
    {
        public static void toPrint<X>(X[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(int[] inputArray)
        {
            foreach (int element in inputArray) 
            {
                Console.WriteLine(element );
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(double[] inputArray)
        {

            foreach (double element in inputArray)
            {
                Console.WriteLine(element );
            }
            Console.WriteLine("----------------------------------");
        }
        public static void toPrint(char[] inputArray)
        {
            foreach (char element in inputArray) 
            {
                Console.WriteLine(element );
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}

