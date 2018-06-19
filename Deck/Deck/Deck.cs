using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardCollection
{
    public class Deck<X> : IEnumerable
    {
        X[] cardDeck = new X[15];

        int count;

        /// <summary>
        /// Adding a card to the List if its not already in there
        /// and then resizing it if necessary
        /// </summary>
        /// <param name="card">card to be added</param>
        /// <returns></returns>
        public bool Add(X card)
        {
            bool newlyAdded = false;

            for (int i = 0; i < cardDeck.Length; i++)
            {
                if (card.Equals(cardDeck[i]))
                {
                    Console.WriteLine("I'm already in the deck");
                    return newlyAdded;
                }
            }
            if (count == cardDeck.Length)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }
            newlyAdded = true;
            cardDeck[count++] = card;

            count = cardDeck.Length;
            return newlyAdded;
        }

        /// <summary>
        /// takes the count and decrements it each iterationas a random card
        /// is placed at a new index, solution based on a stack overflow
        /// </summary>
        public bool Shuffle()
        {
            int toShuffle = cardDeck.Length;
            //count = cardDeck.Length;

            Random shuffling = new Random();
            while (toShuffle > 1)
            {
                toShuffle--;
                int randomCard = shuffling.Next(toShuffle + 1);
                X value = cardDeck[randomCard];
                cardDeck[randomCard] = cardDeck[toShuffle];
                cardDeck[toShuffle] = value;
            }
            //count = cardDeck.Length;

            return true;
        }


        /// <summary>
        /// If the specified card is in the list, remove it
        /// </summary>
        /// <param name="card">card you want to remove</param>
        /// <returns></returns>
        public bool Remove(X card)
        {
            bool isRemoved = false;
            //count = cardDeck.Length;

            for (int i = 0; i < cardDeck.Length; i++)
            {
                if (card.Equals(cardDeck[i]))
                {
                    cardDeck[i] = default;

                    isRemoved = true;
                    Console.WriteLine($" Successfully removed");
                    //count = cardDeck.Length;
                    return isRemoved;
                }
            }

            //count = cardDeck.Length;
            Console.WriteLine("That card was not found in the deck");
            return isRemoved;
        }


        //print the cards out to the console 
        //and show how many cards are currently in the deck
        public void Print(Deck<Cards> deck)
        {
            int showCount = 1;
            foreach (Cards card in deck)
            {
                if(card != null)
                {
                Console.WriteLine($"{showCount} _ {card.CardNumber} of {card.CardSuit}");
                showCount++;
                }
            }
        }


        public IEnumerator<X> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cardDeck[i];
            }
        }

        // Magic Don't Touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
