using System;
using System.Collections.Generic;
using System.Text;

namespace CodilityTests
{
    public class Car
    {

        public string model;
        public string color;
        public int year;

        public void FullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can");
        }



    }

    abstract class Animal
    {
        public abstract void Honk();
       
    }

     class Pig : Animal
    {
        public override void Honk()
        {
            Console.WriteLine("WEEEEEEE");
        }
    }
     class Dog : Animal
    {
        public override  void Honk()
        {
            Console.WriteLine("WUUUUUF WUUUF");
        }
    }
}
