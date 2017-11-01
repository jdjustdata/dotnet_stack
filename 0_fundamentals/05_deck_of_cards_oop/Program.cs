﻿using System;

namespace _05_deck_of_cards_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck playerDeck = new Deck();
            Player player1 = new Player("Sue");
            Player player2 = new Player("Tom");
            // playerDeck.ShowDeck();
            // Card topCard = playerDeck.PullCard();
            // Console.WriteLine("First card = " + topCard.suit + ", " + topCard.stringVal);
            // playerDeck = playerDeck.Reset();
            // playerDeck.ShowDeck();
            playerDeck.Shuffle();
            playerDeck.ShowDeck();
            // playerDeck.CountCardTypes();
            player1.Draw(playerDeck);
            player1.Draw(playerDeck);
            player1.Draw(playerDeck);
            player1.ShowHand();
            Console.WriteLine("Discarding Second Card");
            player1.Discard(playerDeck, 1);
            Console.WriteLine("Hand after discard:");
            player1.ShowHand();
            Console.WriteLine("The Deck's Discard Pile is currently:");
            playerDeck.ShowDiscard();
            player2.Draw(playerDeck);
        }
    }
}
