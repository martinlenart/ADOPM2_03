using System;

namespace ADOPM2_03_07
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
            Shape s1 = new Shape() { Height = 100, Width = 200 };

            //var r1 = (Rectangle) s1;                     //Casting with Exception
            var r1 = s1 as Rectangle;                      //Casting without Exception
            //Console.WriteLine(r1.Area);                    //Null Exception

            var r2 = new Rectangle() { Height = 100, Width = 200 };
            if (r2 is Rectangle r4)                             //will work, r2 is really an instance of Rectangle
            {
                Console.WriteLine(r4.GetType());
                Console.WriteLine(r4.Area);

                var s2 = (Shape)r4;                             //Rectangle is a Shape, so this will work
                Console.WriteLine(s2.Width);
            }
        }
    }
    //Excercises:
    //1.    Add code at the end "if (r2 is Shape r5)" and try to printout r5 type and Area. What happens?
    //2.    Experiment by Creating Rectangle, Triangle and Circle instances, use "is" and "as" to cast the types to Shape and back.
}
