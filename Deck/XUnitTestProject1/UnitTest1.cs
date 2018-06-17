using System;
using System.Collections;
using Xunit;
using CardCollection;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddACard()
        {

            //Ace of spades
            Cards card1 = new Cards((CardType)1, (Suit)1);
            //two of clubs
            Cards card2 = new Cards((CardType)2, (Suit)2);

            Deck<Cards> deck = new Deck<Cards> { card1 };



            Assert.True(deck.Add(card1));
            Assert.True(deck.Add(card2));
        }

        [Fact]
        public void TestMakeACard()
        {

            //10 of clubs
            Cards card10 = new Cards((CardType)10, (Suit)2);
            //king of spades
            Cards card13 = new Cards((CardType)13, (Suit)1);

            Assert.Equal("Ten", card10.CardNumber.ToString());
            Assert.Equal("Club", card10.CardSuit.ToString());

            Assert.Equal("King", card13.CardNumber.ToString());
            Assert.Equal("Spade", card13.CardSuit.ToString());
        }

        [Fact]
        public void TestRemoveACardThatExists()
        {

        }
        [Fact]
        public void TestRemoveACardThatDoesntExist()
        {

        }

        [Fact]
        public void TestShuffleDeck()
        {
            //Ace of spades
            Cards card1 = new Cards((CardType)1, (Suit)1);
            //two of clubs
            Cards card2 = new Cards((CardType)2, (Suit)2);
            //10 of clubs
            Cards card10 = new Cards((CardType)10, (Suit)2);
            //king of spades
            Cards card13 = new Cards((CardType)13, (Suit)1);

            Deck<Cards> deck = new Deck<Cards> { card1, card2, card10, card13 };

            Assert.True(deck.Shuffle());
        }
    }
}
