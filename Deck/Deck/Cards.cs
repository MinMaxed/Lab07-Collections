using System;
using System.Collections.Generic;
using System.Text;

namespace CardCollection
{
    class Cards
    {

        public int CardNumber { get; set; }

        public Suit CardSuit { get; set; }




        public Cards(int Number, Suit suit)
        {
            CardNumber = Number;
            CardSuit = suit;

        }
    }

    enum Suit
    {
        Spade = 1,
        Club,
        Heart,
        Diamond
    }



}
