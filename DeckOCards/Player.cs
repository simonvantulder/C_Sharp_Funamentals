using System.Collections.Generic;
using System;

namespace DeckOCards
{
    public class Player
    {
        public string Name;

        public List<Card> Hand = new List<Card>();

        public Player(string name){
            Name = name;
        }

        public Card Draw(Card item){ //name the deck bicycle passed into the function bicycle
            Hand.Add(item);
            return item;

        }

        public Card Discard(int index){
            if (Hand.Count == 0){
                return null;
            }
            Card temp = Hand[index]; 
            Hand.RemoveAt(index);

            return temp;
        } 

        public void PrintDeck(){
            foreach(Card card in Hand){
                Console.WriteLine($"{card.StringVal} {card.Suit}" );
            }
        }


    }
}

