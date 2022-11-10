using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_01
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	interface IPlayingCard
	{
		/// <summary>
		/// The color of a playing card.
		/// </summary>
		PlayingCardColor Color { get; init; }
		
		/// <summary>
		/// The value Two - Ace of the card
		/// </summary>
		PlayingCardValue Value { get; init; }

	}
}
