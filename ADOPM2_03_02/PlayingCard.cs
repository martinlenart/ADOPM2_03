using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_02
{
    class PlayingCard : IPlayingCard
    {
		PlayingCardColor _color;
		public PlayingCardColor Color
		{ 
		  get {return _color; }
		  init { _color = value; } 
		}
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public string StringToPrint => $"{Value} of {Color}, a {BlackOrRed} card";
	}
	struct structPlayingCard : IPlayingCard
	{
		PlayingCardColor _color;
		public PlayingCardColor Color
		{
			get { return _color; }
			init { _color = value; }
		}
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		public string StringToPrint => $"{Value} of {Color}, a {BlackOrRed} card";
	}

}
