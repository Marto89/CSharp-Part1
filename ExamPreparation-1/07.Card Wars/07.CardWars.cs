using System;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int allGames = int.Parse(Console.ReadLine());

        const int playerCards = 3;
        BigInteger playerOneGlobalScores=0, playerTwoGlobalScores=0,playersOneWon = 0 ,playersTwoWon=0;
        bool playerOneXCard = false;
        bool playerTwoXCard = false;

        for (int i = 0; i < allGames; i++)
        {
           int playerOneLocalScores = 0;
           int playerTwoLocalScores = 0;

           for (int j = 0; j < playerCards; j++)
           {
               string cards = Console.ReadLine();
               switch (cards)
               {
                   case "A": playerOneLocalScores += 1;
                       break;
                   case "J": playerOneLocalScores += 11;
                       break;
                   case "Q": playerOneLocalScores += 12;
                       break;
                   case "K": playerOneLocalScores += 13;
                       break;
                   case "Z": playerOneGlobalScores *= 2;
                       break;
                   case "Y": playerOneGlobalScores -= 200;
                       break;
                   case "X": playerOneXCard = true;
                       break;
                   default: playerOneLocalScores += 12 - int.Parse(cards);
                       break;
               }
           }
           for (int j = 0; j < playerCards; j++)
           {
               string cards = Console.ReadLine();
               switch (cards)
               {
                   case "A": playerTwoLocalScores += 1;
                       break;
                   case "J": playerTwoLocalScores += 11;
                       break;
                   case "Q": playerTwoLocalScores += 12;
                       break;      
                   case "K": playerTwoLocalScores += 13;
                       break;      
                   case "Z": playerTwoGlobalScores *= 2;
                       break;      
                   case "Y": playerTwoGlobalScores -= 200;
                       break;      
                   case "X": playerTwoXCard = true;
                       break;
                   default: playerTwoLocalScores += 12 - int.Parse(cards);
                       break;
               }
           }
           if (playerOneXCard == true && playerTwoXCard == true)
           {
               playerOneGlobalScores += 50;
               playerTwoGlobalScores += 50;
               playerOneXCard=false;
               playerTwoXCard=false;
           }
           else if (playerOneXCard == true)
           {
               Console.WriteLine("X card drawn! Player one wins the match!");
               return;
           }
           else if(playerTwoXCard==true)
           {
               Console.WriteLine("X card drawn! Player two wins the match!");
               return;
           }

           if (playerOneLocalScores > playerTwoLocalScores)
           {
               playerOneGlobalScores += playerOneLocalScores;
               playersOneWon++;
           }
           else if (playerOneLocalScores < playerTwoLocalScores)
           {
               playerTwoGlobalScores += playerTwoLocalScores;
               playersTwoWon++;
           }
        }
        if (playerOneGlobalScores > playerTwoGlobalScores)
        {
            Console.WriteLine("First player wins!\nScore: {0} \nGames won: {1}",playerOneGlobalScores,playersOneWon);
        }
        else if (playerOneGlobalScores < playerTwoGlobalScores)
        {
            Console.WriteLine("Second player wins!\nScore: {0} \nGames won: {1}", playerTwoGlobalScores, playersTwoWon);
        }
        else
        {
            Console.WriteLine("It's a tie!\n Score: {0}",playerOneGlobalScores);
        }
    }
}
