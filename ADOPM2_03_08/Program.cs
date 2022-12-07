using System;
using System.Collections.Generic;

namespace ADOPM2_03_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var chef = new Chef();
            Console.WriteLine(chef.FavoriteDish);

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
            myChefs.Add(new SouthSwedishChef());
            
            FavoritesToConsole(myChefs);
        }

        static void FavoritesToConsole(List<IChef> theList)
        {
            foreach (var item in theList)
            {
                Console.WriteLine(item);
                
                if (item is SwedishChef swede)
                {
                    Console.WriteLine($"And my name is {swede.Name}, " +
                        $"I am {swede.Age} years old and I love {swede.FavoriteDish}");
                }
            }
        }
    }

    //Excercises:
    //1.    Explain the Name, FavoriteDish, Age of the SouthSwedishChef
}
