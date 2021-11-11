using System;

namespace ADOPM2_03_08
{
    class Program
    {
        public class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public virtual bool Equals(Shape s1) => throw new NotImplementedException();
        }
        // Triangle is derived from Shape.  
        public class Triangle : Shape
        {
            public double Area() => Width * Height / 2;
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
            Shape s1 = new Shape() { Height = 100, Width = 200 };
            Shape s2 = new Shape() { Height = 100, Width = 200 };
            //Console.WriteLine(s1.Equals(s2)); // Exception

            var r1 = new Rectangle() { Height = 100, Width = 200 };
            var r2 = new Rectangle() { Height = 100, Width = 200 };
            var r3 = new Rectangle() { Height = 50, Width = 200 };
            Console.WriteLine(r1.Equals(r2)); // true
            Console.WriteLine(r1.Equals(r3)); // false

            var s3 = r1 as Shape;
            var s4 = r2 as Shape;
            //Console.WriteLine(s3.Equals(s4)); // Exception
        }
    }

    //Excercises:
    //1.    use "new" instead of "override" keyword. What happens? Why?
    //2.    Make create a virtual method Area() in  part of Shape. Test with "new" and "override" 
    //3.    Implement Circumference property in Shape. Virtual?
}
