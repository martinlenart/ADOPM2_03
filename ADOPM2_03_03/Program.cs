using System;

namespace ADOPM2_03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WineCellar wineCellar1 = new WineCellar(
                new IWine[] { new WineMockup(), new WineMockup(), new WineMockup() });

            Console.WriteLine(wineCellar1);
            Console.WriteLine(wineCellar1.MostExpensive());
            */
            
            WineCellar wineCellar1 = new WineCellar(
            new IWine[] {
                new WineStruct("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineClass("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineStruct("Viña Ardanza Reserva", 2012, price:269M),
                new WineClass("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineClass)}");
            Console.WriteLine(wineCellar1);
            Console.WriteLine(wineCellar1.MostExpensive());

            /*
            WineCellar wineCellar2 = new WineCellar(
            new IWine[] {
                new WineStruct("Pesquera Millenium Gran Reserva", 2015, 349M),
                new WineStruct("Cune Imperial Gran Reserva", year:2015, 359M),
                new WineStruct("Viña Ardanza Reserva", 2012, price:269M),
                new WineStruct("Viña Pedrosa Gran Reserva", 2014, 479M) });

            Console.WriteLine($"My WinCellar based on {nameof(WineStruct)}");
            wineCellar2.ViewCellar();
            */
        }
    }

    // Exercises
    // 1.   - Make a new project called AdressList.
    //      - Make in a separate file an interface IAdress containing public properites, Name, StreetName, StreetNumber, ZipCode, Country
    //      - In Main() make an array of IAdress[] and add write a method that Printout out the list. Compile and check it compiles
    //      - Implement IAdress as a class Adress and fill IAdress arrayn with a few adresses and printout

    // 2.   Create a WineCellar with mixed WineClass and WineStruct.
    // 3.   In WineCellar.ViewCellar() print out the type IWine is implemented in in the foreach loop
    // 4.   Make IWine immutable and implement as a record


}
