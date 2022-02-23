using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_03
{
    public interface IWine : IComparable<IWine>    
    {
        string Name { get; set; }
        int Year { get; set; }
        decimal Price { get; set; }
        string ToString();
    }
}
