using System;

namespace DeckOCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Bicycle = new Deck();
            Console.WriteLine(Bicycle);
            Player RP1 = new Player("ReadyPlayerOne");
            Console.WriteLine(RP1);

            Bicycle.Shuffle();
            Bicycle.Deal(Bicycle);
            Bicycle.PrintDeck(Bicycle);

            Console.WriteLine("+++++++++++++++");
            Console.WriteLine(Bicycle.Reset(Bicycle));
            Console.WriteLine("+++++++++++++++++++");

            Bicycle.PrintDeck(Bicycle);

            RP1.PrintDeck();
            RP1.Draw(Bicycle.Deal(Bicycle));
            RP1.Discard(0);
            RP1.PrintDeck();

        }
    }
}
