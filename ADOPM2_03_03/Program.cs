using System;

namespace ADOPM2_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WineCellar wineCellar1 = new WineCellar(
                new IWine[] { new WineMockup(), new WineMockup(), new WineMockup() });

            Console.WriteLine(wineCellar1);
            Console.WriteLine(wineCellar1.MostExpensive());
            
            
            /*
            WineCellar wineCellar1 = new WineCellar(
            new IWine[] {
                new WineStruct("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineClass("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineStruct("Viña Ardanza Reserva", 2012, price:269M),
                new WineClass("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineClass)}");
            Console.WriteLine(wineCellar1);
            Console.WriteLine(wineCellar1.MostExpensive());
            */
        }
    }

    // Exercises
    // 1.   - Make a new project called FriendList.
    //      - Make in a separate file an interface IFriend containing public properites, FirstName, LastName
    //      - In Main() make an array of IFriend[] and add write a method that Printout out the list. Compile and check it compiles
    //      - Implement IFriend as a class Friend and fill the array with 100 random created friend names.
    //      Hint: Use a class factory method, CreateRandom(), that creates and returns an instance of Friend, initialized with random values.


}
