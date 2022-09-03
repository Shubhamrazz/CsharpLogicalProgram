using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    //Abstraction
    abstract class Shape
    {
        //abstract method
        public abstract int area(); 
    }
    class Square : Shape
    {
        //private data member
        private int side;
        //method of square class
        public Square(int x = 0)
        {
            side = x;
        }
        //overridding the abstract method of Shape
        public override int area()
        {
            Console.WriteLine("Area of Square: " );
            return (side * side);
        }
    }
}
