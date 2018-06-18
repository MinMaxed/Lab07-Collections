using System;

namespace CardCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Ace of spades
            Cards card1 = new Cards((CardType)1, (Suit)1);
            //two of clubs
            Cards card2 = new Cards((CardType)2, (Suit)2);
            //three of hearts
            Cards card3 = new Cards((CardType)3, (Suit)3);
            //four of diamonds
            Cards card4 = new Cards((CardType)4, (Suit)4);
            //five of spades
            Cards card5 = new Cards((CardType)5, (Suit)1);
            //six of clubs
            Cards card6 = new Cards((CardType)6, (Suit)2);
            //seven of hearts
            Cards card7 = new Cards((CardType)7, (Suit)3);
            //eight of diamonds
            Cards card8 = new Cards((CardType)8, (Suit)4);
            //nine of spades
            Cards card9 = new Cards((CardType)9, (Suit)1);
            //10 of clubs
            Cards card10 = new Cards((CardType)10, (Suit)2);
            //jack of hearts
            Cards card11 = new Cards((CardType)11, (Suit)3);
            //queen of diamonds
            Cards card12 = new Cards((CardType)12, (Suit)4);
            //king of spades
            Cards card13 = new Cards((CardType)13, (Suit)1);
            //ace of clubs
            Cards card14 = new Cards((CardType)1, (Suit)2);
            //two of hearts
            Cards card15 = new Cards((CardType)2, (Suit)3);

            //Initial filling of the deck
            Deck<Cards> deck = new Deck<Cards> { card1, card2, card3, card4, card5, card6,
            card7, card8, card9, card10, card11, card12, card13, card14, card15};


            //foreach (Cards card in deck)
            //{
            //    Console.WriteLine($"{card.CardNumber} of {card.CardSuit}");
            //}

            //Console.ReadKey();
            //Console.WriteLine("-----------------");


            //three of diamonds
            Cards card16 = new Cards((CardType)3, (Suit)4);


            //using add method
            deck.Add(card16);



            foreach (Cards card in deck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit}");
            }
            //deck.Print();
            Console.ReadKey();
            Console.Clear();
            deck.Remove(card16);


            foreach (Cards card in deck)
            {
                if (card != null)
                {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit}");
                }
            }
            //deck.Print();
            Console.ReadKey();

        }
    }
}
