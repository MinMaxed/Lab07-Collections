using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardCollection
{
    public class Deck<X> : IEnumerable
    {
        X[] cardDeck = new X[15];

        int count = 0;

        //Add Method
        public bool Add(X card)
        {
            bool newlyAdded = false;

            if (cardDeck.Equals(card))
            {
                Console.WriteLine("I'm already in the deck");
                return newlyAdded;
            }
                   
            if (count == cardDeck.Length)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }
                newlyAdded = true;
            cardDeck[count++] = card;

            return newlyAdded;
        }

        //rng for shuffling
        private static Random shuffling = new Random();
        /// <summary>
        /// takes the count and decrements it each iterationas a random card
        /// is placed at a new index, solution based on a stack overflow
        /// </summary>
        public bool Shuffle()
        {
            bool shuffled = false;
            int toShuffle = cardDeck.Length;
            if (shuffled == false)
            {

                while (toShuffle > 1)
                {
                    toShuffle--;
                    int randomCard = shuffling.Next(0, toShuffle + 1);
                    X value = cardDeck[randomCard];
                    cardDeck[randomCard] = cardDeck[toShuffle];
                    cardDeck[toShuffle] = value;
                    shuffled = true;
                }
            }
            return shuffled;
        }


        //remove a card
        public void Remove(X card)
        {
            for (int i = 0; i < cardDeck.Length; i++)
            {
                if (card.Equals(cardDeck[i]))
                {
                    cardDeck.(i);
                }
            }



        }


        //print the cards
        public void Print()
        {
            count = cardDeck.Length;
            for (int i = 0; i < count; i++)
            {
                if (cardDeck[i] != null)
                {
                    Console.WriteLine($"{cardDeck[i]} {i + 1}");
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
