using System;
namespace ADOPM2_03_03
{
	public class WineMockup : IWine
	{
		public string Name { get; set; } = "Lynx";
		public int Year { get; set; } = 2020;
		public decimal Price { get; set; }

		public int CompareTo(IWine other) => this.Price.CompareTo(other.Price);

        public override string ToString()
        {
			return $"{Name}, {Year}, {Price}";
		}
        public WineMockup()
		{
			var rnd = new Random();
			Price = rnd.Next(90, 120);
		}
	}
}

