using System;

namespace ADOPM2_03_02
{
	class Program
	{
		static void Main(string[] args)
		{
			// Now I have an implementation and can make an instance
			IPlayingCard card1 = new PlayingCard { Color = PlayingCardColor.Diamonds, Value = PlayingCardValue.Three }; 
			IPlayingCard card2 = new structPlayingCard { Color = PlayingCardColor.Spades, Value = PlayingCardValue.Five };

			// no change in code here, but now I can test run
			CompareTwoCards(card1, card2);

			var card3 = ReturnOne(card1, card2);
            Console.WriteLine(card3.GetType());
		}

		// no change in code here
		static  void CompareTwoCards(IPlayingCard card1, IPlayingCard card2)
		{
			if (card1.Value > card2.Value)
				Console.WriteLine($"{card1.Value} beats {card2.Value}");
			else if (card1.Value < card2.Value)
				Console.WriteLine($"{card2.Value} beats {card1.Value}");

			else
			{
				//Same Value
				if (card1.Color > card2.Color)
					Console.WriteLine($"Both cards same value {card1.Value} but {card1.Color} beats {card2.Color}");
				else
					Console.WriteLine($"Both cards same value {card1.Value} but {card2.Color} beats {card1.Color}");
			}
		}

		static IPlayingCard ReturnOne(IPlayingCard card1, IPlayingCard card2)
        {
			if (card1 is PlayingCard) return card1;
			else return card2;
        }
	}
}
