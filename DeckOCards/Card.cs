namespace DeckOCards
{
    public class Card
    {
        public string StringVal;
        public int Val;
        // Foods can be Spicy and/or Sweet
        public string Suit; 

        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Card(string stringVal, int val, string suit){
        StringVal = stringVal;
        Val = val;
        Suit = suit;
        }
    }
}