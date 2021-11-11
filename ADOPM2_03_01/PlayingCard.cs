using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPM2_03_01
{
    #region Pure Mockup implementation, only implement to test my CompareTwoCards
    class PlayingCard1 : IPlayingCard
    {
        public PlayingCardColor Color { get => PlayingCardColor.Clubs; init => throw new NotImplementedException(); }
        public PlayingCardValue Value { get => PlayingCardValue.Three; init => throw new NotImplementedException(); }

        public string BlackOrRed => throw new NotImplementedException();

        public string StringToPrint => throw new NotImplementedException();
    }
    class PlayingCard2 : IPlayingCard
    {
        public PlayingCardColor Color { get => PlayingCardColor.Diamonds; init => throw new NotImplementedException(); }
        public PlayingCardValue Value { get => PlayingCardValue.Five; init => throw new NotImplementedException(); }

        public string BlackOrRed => throw new NotImplementedException();

        public string StringToPrint => throw new NotImplementedException();
    }
    #endregion
}
