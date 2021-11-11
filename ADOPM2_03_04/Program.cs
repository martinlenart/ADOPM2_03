using System;

namespace ADOPM2_03_04
{
    class Program
    {
		//two interfaces with same member names
		interface IRectangle { 
			double Width { get; set; }
			double Height { get; set; }
			double Area {get;} }
		interface IFilledShape { double Area { get; } }

		//Implementing multiple interfaces with conflicting member names
		public class FilledRectangle : IRectangle, IFilledShape
		{
			public double Width { get; set; }
			public double Height { get; set; }

			// has to be implemented but will be kept private
			double IFilledShape.Area => Width * Height;

			// This is the Area my implementation wants to make public
			public double Area => Width * Height;
		}
		
		static void Main(string[] args)
        {
			FilledRectangle filledRectangle = new FilledRectangle { Width = 100, Height = 200 };
			
			Console.WriteLine(filledRectangle.Area);
        }
    }
}
