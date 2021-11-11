using System;

namespace ADOPM2_03_09
{
    class Program
    {
        //Base class or Parent class. 
        public abstract class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public abstract bool Equals(Shape s1);
        }
        // Triangle is derived from Shape.  
        public class Triangle : Shape
        {
            public double Area => Width * Height / 2;
            public override bool Equals(Shape t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
        }
        // Rectangle is derived from Shape
        public class Rectangle : Shape
        {
            public double Area() => Width * Height;
            public override bool Equals(Shape r1) => (this.Width, this.Height) == (r1.Width, r1.Height);
         }
        static void Main(string[] args)
        {
            //Shape s1 = new Shape() { Height = 100, Width = 200 }; // Error
            //Shape s2 = new Shape() { Height = 100, Width = 200 }; // Error

            var r1 = new Rectangle() { Height = 100, Width = 200 };
            var r2 = new Rectangle() { Height = 100, Width = 200 };
            Console.WriteLine(r1.Equals(r2)); // true

            var s3 = r1 as Shape;
            var s4 = r2 as Shape;
            Console.WriteLine(s3.Equals(s4)); // true
        }
    }

    //Excercises:
    //1.    Explain why s3.Equals(s4) with Shape works in this Example, but not in Example1.19
    //2.    Try using "new" keyword instead of "override". What happens?, why?
}
