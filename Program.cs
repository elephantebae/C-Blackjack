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
                Console.WriteLine(player1);
                Deck newdeck = new Deck();
                newdeck.Shuffle();
            }
        }
        
        
    }
    
}
