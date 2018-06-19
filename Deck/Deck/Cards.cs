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


        //card template with two values, type and suit
        public Cards(CardType Number, Suit suit)
        {
            CardNumber = Number;
            CardSuit = suit;
        }
    }

    //Enum for the card suits
    public enum Suit
    {
        Spade = 1,
        Club,
        Heart,
        Diamond
    }
    //enum for the card value/type
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
