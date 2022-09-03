using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpProgramming
{
    //Concept of Class,Object and Constructor
    public class Dog
    {
        string name;
        string color;
        string breed;
        int age;

        public Dog(string name,string color,string breed,int age)
        {
            this.name = name;
            this.color = name;
            this.breed = breed;
            this.age = age;
        }
        //Properties
        public string Name()
        {
            return name;
        }
        public string Breed()
        {
            return breed;
        }
        public string Color()
        {
            return color;
        }
        public int Age()
        {
            return age;
        }
        //Method
        public string Tostring()
        {
            return ("Hi my name is" + this.Name() +"\nMy Breed,Color and Age are" +this.Breed()+","+this.Color()+","+this.Age());
        }
    }
}
