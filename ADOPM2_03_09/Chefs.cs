using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_09
{
    public interface IChef
    {
        public string? Name { get; set; }
        public string? FavoriteDish { get; set; }
    }

    abstract public class Chef : IChef
    {
        virtual public string? Name { get; set; } = "Boring";
        virtual public string? FavoriteDish { get; set; } = "none";
        public override string ToString()
        {
            return $"Hello, my name is {Name}. I just love {FavoriteDish}";
        }
    }
    public class FrenchChef : Chef
    {
        override public string? Name { get; set; } = "Pierre";
        override public string? FavoriteDish { get; set; } = "snails";
    }
    public class GermanChef : Chef
    {
        override public string? Name { get; set; } = "Franz";
        override public string? FavoriteDish { get; set; } = "wurst";
    }
    public class ItalianChef : Chef
    {
        override public string? Name { get; set; } = "Mauro";
        override public string? FavoriteDish { get; set; } = "pizza";
    }
    sealed public class SwedishChef : Chef
    {
        override public string? Name { get; set; } = "Lars";
        override public string? FavoriteDish { get; set; } = "meatballs";
        public int Age = 35;
    }

    //below Error as SwedisChef is sealed
    /*
    public class SouthSwedishChef : SwedishChef
    {
        override public string? FavoriteDish { get; set; } = "herring";
    }
    */
}
