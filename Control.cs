using System.Collections.Generic;
using System;
namespace deck
{
    // variable player input gotten from readline in the turnloop = Pchoice

    class Control
    {
        public static void choice(string Pchoice, Deck deck, Player player){
            if(Pchoice == "hit"){
                player.Draw(deck);
            }
        }
        
    }
}