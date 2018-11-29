namespace deck
{
    class Card{
            string StringVal; 
            string Suit;
            public int Val;

        public Card(string suit, int val, string strval){
                StringVal = strval;
                Suit = suit;
                Val = val; 

            }
        public override string ToString(){
            return $"{StringVal}, of {Suit}";
        }
    }
} 