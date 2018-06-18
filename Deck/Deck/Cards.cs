using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardCollection
{
    public class Cards
    {

        public CardType CardNumber { get; set; }

        public Suit CardSuit { get; set; }


        public Cards(CardType Number, Suit suit)
        {
            CardNumber = Number;
            CardSuit = suit;
        }
    }

    public enum Suit
    {
        Spade = 1,
        Club,
        Heart,
        Diamond
    }

    public enum CardType
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }



}
