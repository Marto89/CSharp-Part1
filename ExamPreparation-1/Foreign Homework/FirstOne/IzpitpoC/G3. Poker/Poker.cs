using System;

class Poker
{
    static void Main(string[] args)
    {
        string[] cards = new string[5];
        int[] allCards = new int [5];

        for (int i = 0; i < 5; i++)
        {
            cards[i] = Console.ReadLine(); 

            switch(cards[i])
            {
                case "2":
                    allCards[i] = 2;
                    break;
                case "3":
                    allCards[i] = 3;
                    break;
                case "4":
                    allCards[i] = 4;
                    break;
                case "5":
                    allCards[i] = 5;
                    break;
                case "6":
                    allCards[i] = 6;
                    break;
                case "7":
                    allCards[i] = 7;
                    break;
                case "8":
                    allCards[i] = 8;
                    break;
                case "9":
                    allCards[i] = 9;
                    break;
                case "10":
                    allCards[i] = 10;
                    break;
                case "J":
                    allCards[i] = 11;
                    break;
                case "Q":
                    allCards[i] = 12;
                    break;
                case "K":
                    allCards[i] = 13;
                    break;
                case"A":
                    allCards[i] = 1;
                    break;
                    
            }
            
        }
        Array.Sort(allCards);

        int firstCard = allCards[0];
        int secondCard = allCards[1];
        int thirdCard = allCards[2];
        int fourdCard = allCards[3];
        int fiftCard = allCards[4];

        if (firstCard == secondCard && secondCard == thirdCard && thirdCard == fourdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Impossible"); return;
        }

         if (firstCard == secondCard && secondCard == thirdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Full House"); return;
        }

         if (firstCard == secondCard && secondCard ==fourdCard &&  thirdCard==fiftCard)
        {
            Console.WriteLine("Full House"); return;
        }

         if (firstCard == secondCard && secondCard == fiftCard && thirdCard == fourdCard)
        {
            Console.WriteLine("Full House"); return;
        }

        if (firstCard == thirdCard && thirdCard == fiftCard && secondCard == fourdCard)
        {
            Console.WriteLine("Full House"); return;
        }

        if (firstCard == thirdCard && thirdCard == fourdCard && secondCard == fiftCard)
        {
            Console.WriteLine("Full House"); return;
        }

          if (thirdCard == fourdCard && fourdCard == fiftCard && firstCard == secondCard)
        {
            Console.WriteLine("Full House"); return;
        }

        if (secondCard == fourdCard && fourdCard == fiftCard && firstCard == thirdCard)
        {
            Console.WriteLine("Full House"); return;
        }

         if (secondCard == thirdCard && thirdCard == fiftCard && firstCard == fourdCard)
        {
            Console.WriteLine("Full House"); return;
        }

        if (secondCard == thirdCard && thirdCard == fourdCard && firstCard == fiftCard)
        {
            Console.WriteLine("Full House"); return;
        }

         if (firstCard == fourdCard && fourdCard == fiftCard && secondCard == thirdCard)
        {
            Console.WriteLine("Full House"); return;
        }

          if (firstCard == secondCard && secondCard == thirdCard && thirdCard == fourdCard )
        {
            Console.WriteLine("Four of a Kind"); return;
        }

         if (firstCard == secondCard && secondCard == thirdCard && thirdCard == fiftCard)
        {
            Console.WriteLine("Four of a Kind"); return;
        }

        if (firstCard == secondCard && secondCard == fourdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Four of a Kind"); return;
        }

         if (firstCard == thirdCard && thirdCard == fourdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Four of a Kind"); return;
        }

         if (secondCard == thirdCard && thirdCard == fourdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Four of a Kind"); return;
        }

         else if (firstCard == secondCard && secondCard == thirdCard || firstCard == secondCard && secondCard == fourdCard || firstCard == secondCard && secondCard == fiftCard || firstCard == thirdCard && thirdCard == fourdCard || firstCard == thirdCard && thirdCard == fiftCard || firstCard == fourdCard && fourdCard == fiftCard || secondCard == thirdCard && thirdCard == fourdCard || secondCard == thirdCard && thirdCard == fourdCard||secondCard == thirdCard && thirdCard == fiftCard || secondCard == fourdCard && fourdCard == fiftCard || thirdCard == fourdCard && fourdCard == fiftCard)
        {
            Console.WriteLine("Three of a Kind");
            return;
        }


         if (firstCard == secondCard && fourdCard == fiftCard || firstCard == secondCard && thirdCard == fourdCard || firstCard == thirdCard && fourdCard == fiftCard || firstCard == secondCard && thirdCard == fiftCard || firstCard == thirdCard && secondCard == fourdCard || firstCard == thirdCard && secondCard == fiftCard || firstCard == fourdCard && secondCard == thirdCard || firstCard == fourdCard && secondCard == fiftCard || firstCard == fourdCard && thirdCard == fiftCard || firstCard == fiftCard && secondCard == thirdCard || firstCard == fiftCard && secondCard == fourdCard || firstCard == fiftCard && thirdCard == fourdCard || secondCard == thirdCard && fourdCard == fiftCard || secondCard == fourdCard && thirdCard == fiftCard || secondCard == fiftCard && thirdCard == fourdCard)
        {
            Console.WriteLine("Two Pairs");
            return;
        }

         if (firstCard == secondCard || firstCard == thirdCard || firstCard == fourdCard || firstCard == fiftCard || secondCard == thirdCard || secondCard == fourdCard || secondCard == fiftCard || thirdCard == fourdCard || thirdCard == fiftCard || fourdCard == fiftCard)
        {
            Console.WriteLine("One Pair");
            return;
        }

         if (firstCard == secondCard - 1 && secondCard == thirdCard - 1 && thirdCard == fourdCard - 1 && fourdCard == fiftCard - 1 || secondCard == thirdCard - 1 && thirdCard == fourdCard - 1 && fourdCard == fiftCard +12)
        {
            Console.WriteLine("Straight");
            return;
        }

        //else  (firstCard != secondCard && firstCard != thirdCard && firstCard != fourdCard && firstCard != fiftCard && secondCard != thirdCard && secondCard != fourdCard && secondCard != fiftCard && thirdCard != fourdCard && thirdCard != fiftCard && fourdCard != fiftCard)
        else 
        {
            Console.WriteLine("Nothing");
            return;
        }
    }
}


