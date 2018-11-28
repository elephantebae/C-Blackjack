using System;
using System.Collections.Generic;
namespace deck
{
    class Deck{
            public List<Card> cards = new List<Card>();
            Random rand = new Random();
            public Deck(){
                int [] val = {1,2,3,4,5,6,7,8,9,10,10,10,10};
                string [] suit = {"Clubs","Spades","Hearts","Diamonds"};
                string [] strval = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
                for(var i = 0; i < suit.Length; i++){
                    for(var x = 0; x< val.Length; x++){
                        Card addcard = new Card(suit[i],val[x],strval[x]);
                        cards.Add(addcard);
                    }
                }
            }
            public Card Dealtop(){
                Card card = cards[0];
                cards.RemoveAt(0);
                return card;  
            }

            public Deck ResetDeck(Deck Deck){
                Deck reset = new Deck(); 
                return reset; 
            }
            public void Shuffle()
                {
                for(int n= cards.Count-1; n>0; n--){
                    int k = rand.Next(n+1);
                    Card temp = cards[n];
                    cards[n] = cards[k];
                    cards[k] = temp;
                }
            }
        }
}