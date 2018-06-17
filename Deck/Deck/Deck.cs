using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardCollection
{
    class Deck<X> : IEnumerable
    {
        X[] cardDeck = new X[26];
        int count = 0;

        //Add Method

        public void Add(X item)
        {
            if (count == cardDeck.Length)
            {
                Array.Resize(ref cardDeck, cardDeck.Length * 2);
            }
            cardDeck[count++] = item;
        }

        private static Random shuffling = new Random();


        /// <summary>
        /// takes the count and decrements it each iterationas a random card
        /// is placed at a new index
        /// </summary>
        public void Shuffle()
        {
            count = cardDeck.Length;
            while (count > 1)
            {
                count--;
                int randomCard = shuffling.Next(0, count + 1);
                X value = cardDeck[randomCard];
                cardDeck[randomCard] = cardDeck[count];
                cardDeck[count] = value;
            }
        }

        public void Remove()
        {

        }

        //print the cards
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{cardDeck[i]}");
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
