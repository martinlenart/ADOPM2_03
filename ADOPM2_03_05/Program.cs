using System;

namespace ADOPM2_03_05
{
    class Program
    {
        //Base class or Parent class. 
        public class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        // Triangle is derived from Shape.  
        public class Triangle : Shape
        {
            public double Area => Width * Height / 2;
            public bool Equals(Triangle t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
 
        }
        // Rectangle is derived from Shape
        public class Rectangle : Shape
        {
            public double Area => Width * Height;
            public bool Equals(Rectangle t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
        }
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle() { Height = 100, Width = 200 };
            Shape t2 = new Triangle() { Height = 100, Width = 200 };

            Shape r1 = new Shape() { Height = 100, Width = 200 };
            //var r2 = (Rectangle) r1; //Exception

            Console.WriteLine(t1.Area); // 10000
            Console.WriteLine(((Triangle)t2).Area); // 10000
            Console.WriteLine(((Shape)t2).Height); // 100
           //Console.WriteLine(r2.Area()); //Exception
        }
    }

    //Excercises:
    //1.    Create a derived class Circle, implement Area and Equals
    //2     Add property to all derived classes that calculate the circumference.
    //      Create instances of all derived classes and printout the circumferenance.
}
