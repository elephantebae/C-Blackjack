using System.Collections.Generic;
using System;
namespace deck
{
    // variable player input gotten from readline in the turnloop = Pchoice

    class Control
    {
        public int[] scores;

        public static void choice(string Pchoice, Deck deck, Player player, Player dealer){
            if(Pchoice == "hit"){
                player.Draw(deck);
            }
            if(Pchoice == "stay"){
                // while(scores[1] as int < 17){
                //     dealer.Draw(deck);
                // }
                Console.WriteLine();
            }
        }
        public static int[] check(Player player,Player dealer){
            int dealerscore = 0;
            int playerscore = 0;
            foreach(Card card in dealer.hand){
                dealerscore += card.Val;
            }
            Console.WriteLine("dealer score " + dealerscore);
            foreach (Card card in player.hand)
            {
                playerscore += card.Val;
            }
            Console.WriteLine("player score " + playerscore);
            int[] scores = new int[2]{playerscore,dealerscore};
            return scores;
        }
        
    }
}