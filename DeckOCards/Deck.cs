using System.Collections.Generic;
using System;

namespace DeckOCards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public string[] CardStringValue = new string[] {"Ace", "2","3","4","5","6","7","8","9","10", "Jack", "Queen", "King"};

        public string[] Suits = new string[] {"Hearts", "Diamonds", "Spades", "Clubs"};



        public Deck() //13 cards in 4 suits
{
            foreach (string suit in Suits)
            {
                int cardValue = 1;

                foreach(string face in CardStringValue){
                    Card temp = new Card(face, cardValue, suit);
                    cards.Add(temp);
                    cardValue +=1;
                }
            }
            
}
        public void Shuffle(){
            Random rand = new Random();
            int n = cards.Count;
            while (n > 1){
                n--;
                int rando = rand.Next(n + 1);
                Card temp = cards[rando];
                cards[rando] = cards[n];
                cards[n] = temp;
            }
        }

        public Card Deal(Deck bicycle){
            Card temp = bicycle.cards[0]; 
            bicycle.cards.RemoveAt(0);
            bicycle.cards.Add(temp);
            return temp;

        }

        public Deck Reset(Deck bicycle){
            cards.Clear();
            foreach (string suit in Suits)
            {
                int cardValue = 1;

                foreach(string face in CardStringValue){
                    Card temp = new Card(face, cardValue, suit);
                    cards.Add(temp);
                    cardValue +=1;
                }
            }
            return this;
        }


        public void PrintDeck(Deck bicycle){
            foreach(Card card in cards){
                Console.WriteLine(card.StringVal);
            }
        }



    }
}


