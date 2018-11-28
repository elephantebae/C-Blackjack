using System;
using System.Collections.Generic;
namespace deck{
    class Player{
        public string name; 
        public List<Card> hand = new List<Card>();
        public Player(string newname){
            name = newname;
        }
        public void Draw(Deck Deck){
            Card newcard = Deck.Dealtop();
            hand.Add(newcard); 
        }
        public void ViewHand(){
            for(int i = 0; i<= hand.Count-1; i++){
                Console.WriteLine(hand[i]);
            }
        }
        public Card Discard(int k){
            if(hand[k] != null){
                Card Removedcard =hand[k];
                hand.RemoveAt(k);
                return Removedcard;
            }
            else{
                return null; 
            }

        }
    }



}