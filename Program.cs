using System;
using System.Collections.Generic;

namespace deck
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameloop = true;
            while(gameloop == true)
            {
                Console.WriteLine("Enter Name");
                string line = Console.ReadLine();
                Player player1 = new Player(line);
                Player.Dealer dealer1 = new Player.Dealer(line);
                Deck newdeck = new Deck();
                newdeck.Shuffle();
                dealer1.Draw(newdeck);
                dealer1.Draw(newdeck);
                player1.Draw(newdeck);
                player1.Draw(newdeck);
                Console.WriteLine("your hand");
                player1.ViewHand();
                Console.WriteLine("dealer hand");
                dealer1.ViewHandDealer();
                Console.WriteLine("would you like to hit?");
                string Pchoice = Console.ReadLine();
                Control.choice(Pchoice, newdeck, player1);
                Console.WriteLine("your hand");
                player1.ViewHand();
                Console.WriteLine("dealer hand");
                dealer1.ViewHand();

                gameloop = false;
            }
        }
        
        
    }
    
}
