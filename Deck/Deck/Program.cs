using System;

namespace CardCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Ace of spades
            Cards card1 = new Cards(1, (Suit)1);
            //two of clubs
            Cards card2 = new Cards(2, (Suit)2);
            //three of hearts
            Cards card3 = new Cards(3, (Suit)3);
            //four of diamonds
            Cards card4 = new Cards(4, (Suit)4);
            //five of spades
            Cards card5 = new Cards(5, (Suit)1);
            //six of clubs
            Cards card6 = new Cards(6, (Suit)2);
            //seven of hearts
            Cards card7 = new Cards(7, (Suit)3);
            //eight of diamonds
            Cards card8 = new Cards(8, (Suit)4);
            //nine of spades
            Cards card9 = new Cards(9, (Suit)1);
            //10 of clubs
            Cards card10 = new Cards(10, (Suit)2);
            //jack of hearts
            Cards card11 = new Cards(11, (Suit)3);
            //queen of diamonds
            Cards card12 = new Cards(12, (Suit)4);
            //king of spades
            Cards card13 = new Cards(13, (Suit)1);

            //adding to deck
            Deck<Cards> deck = new Deck<Cards> { card1, card2, card3, card4, card5, card6,
            card7, card8, card9, card10, card11, card12, card13};

            //proof each are there
            foreach (Cards card in deck)
            {
                Console.WriteLine(card.CardSuit);
            }
            Console.ReadKey();

            //ace of clubs
            Cards card14 = new Cards(1, (Suit)2);

        }
    }
}
