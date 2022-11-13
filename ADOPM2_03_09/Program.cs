using System;
using System.Collections.Generic;

namespace ADOPM2_03_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //below two lines Error as Chef is abstract
            //var chef = new Chef();
            //Console.WriteLine(chef.FavoriteDish);

            var chef1 = new FrenchChef();
            Console.WriteLine(chef1.FavoriteDish);

            Chef chef2 = new GermanChef();
            Console.WriteLine(chef2.FavoriteDish);

            List<IChef> myChefs = new List<IChef>();
            myChefs.Add(new GermanChef());
            myChefs.Add(new ItalianChef());
            myChefs.Add(new GermanChef());
            myChefs.Add(new ItalianChef());
            myChefs.Add(new GermanChef());
            myChefs.Add(new SwedishChef());

            
            //myChefs.Add(new SouthSwedishChef()); //Not possible as SwedishChef is sealed

            FavoritesToConsole(myChefs);
        }

        static void FavoritesToConsole(List<IChef> theList)
        {
            foreach (var item in theList)
            {
                Console.WriteLine(item);
                if (item is SwedishChef swede)
                {
                    Console.WriteLine($"And my name is {swede.Age}");
                }

            }
        }
    }

    //Excercises:
    //1.    use "new" instead of "override" keyword. What happens? Why?
    //2.    Make create a virtual method Area() in  part of Shape. Test with "new" and "override" 
    //3.    Implement Circumference property in Shape. Virtual?
}
