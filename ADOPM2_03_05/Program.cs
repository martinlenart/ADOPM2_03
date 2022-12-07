using System;
using System.Collections.Generic;

namespace ADOPM2_03_05
{
    class Program
    {
        public enum myColor { Blue, Green, Red}
        //Base class or Parent class. 
        public class Shape
        {
            public myColor Color { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            virtual public double Area { get;} = 0;

            public Shape()
            {
                Color = myColor.Red;
            }
        }

        
        // Triangle is derived from Shape.  
        public class Triangle : Shape
        {
            override public double Area => Width * Height / 2;
            //            public bool Equals(Triangle t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
            public Triangle()
            {
                Color = myColor.Green;
            }
        }
        // Rectangle is derived from Shape
        public class Rectangle : Shape
        {
            override public double Area => Width * Height;
            //public bool Equals(Rectangle t1) => (this.Width, this.Height) == (t1.Width, t1.Height);
            public Rectangle()
            {
                Color = myColor.Blue;
            }
        }
        
        static void Main(string[] args)
        {
            Shape s1 = new Shape() { Height = 100, Width = 200 };
            Triangle t1 = new Triangle() { Height = 100, Width = 200 };
            Rectangle r1 = new Rectangle() { Height = 100, Width = 200 };

            Console.WriteLine(s1.Color);
            Console.WriteLine(s1.Area);

            Console.WriteLine(t1.Area);
            Console.WriteLine(t1.Color);

            Console.WriteLine(r1.Area);
            Console.WriteLine(r1.Color);

            Shape s2 = new Triangle() { Height = 10, Width = 20 };
            Console.WriteLine(s2.Area);

            Triangle t2 = s2 as Triangle;
            Console.WriteLine(t2.Area);

            
            List<Shape> list = new List<Shape>();
            list.Add(new Shape() { Height = 100, Width = 200 });
            list.Add(new Triangle() { Height = 100, Width = 200 });
            list.Add(new Rectangle() { Height = 100, Width = 200 });

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Area);
                if (item is Rectangle)
                    Console.WriteLine("Oops!");
            }

            /*
            Triangle t1 = new Triangle() { Height = 100, Width = 200 };
            Shape t2 = new Triangle() { Height = 100, Width = 200 };

            Shape r1 = new Shape() { Height = 100, Width = 200 };
            //var r2 = (Rectangle) r1; //compile Exception

            Console.WriteLine(t1.Area); // 10000
            Console.WriteLine(((Triangle)t2).Area); // 10000
            Console.WriteLine(((Shape)t2).Height); // 100
           //Console.WriteLine(r2.Area()); //compile Exception
            */
        }
    }

    //Excercises:
    //1.    Explain why we get the two compile exceptions if we try to create r2
    //2.    Create a derived class Circle, implement Area and Equals
    //3.    Add property to all derived classes that calculate the circumference (omkrets)
    //      Create instances of all derived classes and printout the circumferenance.
}
