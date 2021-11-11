using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_03
{
    //Implementation of IWine as a struct
    public struct WineStruct : IWine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        override public string ToString() => $"{nameof(Name)}: {Name}, {nameof(Year)}: {Year}, {nameof(Price)}: {Price:N2}";

        public WineStruct(string name, int year, decimal price) : this()
        {
            (Name, Year, Price) = (name, year, price);
        }
    }
}
