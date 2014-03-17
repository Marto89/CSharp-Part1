using System;

class Poker
{
    static void Main()
    {
        string [] cards=new string[5];
        int [] realCards=new int[5];

        for (int i = 0; i < 5; i++)
        {
             cards[i] = Console.ReadLine();
       
            switch (cards[i])
            {
                case "2": 
                    realCards[i] = 2; 
                    break;
                case "3":
                    realCards[i] = 3;
                    break;
                case "4":
                    realCards[i] = 4;
                    break;
                case "5":
                    realCards[i] = 5;
                    break;
                case "6":
                    realCards[i] = 6;
                    break;
                case "7":
                    realCards[i] = 7;
                    break;
                case "8":
                    realCards[i] = 8;
                    break;
                case "9":
                    realCards[i] = 9;
                    break;
                case "10":
                    realCards[i] = 10;
                    break;
                case "J":
                    realCards[i] = 11;
                    break;
                case "Q":
                    realCards[i] = 12;
                    break;
                case "K":
                    realCards[i] = 13;
                    break;
                case "A":
                    realCards[i] = 1;
                    break;
            }
        }
        Array.Sort(realCards);

        int firstCard = realCards[0];
        int secondCard = realCards[1];
        int thirdCard = realCards[2];
        int fourthCard = realCards[3];
        int fifthCard=realCards[4];

        if (firstCard == secondCard && secondCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard)
        {
            Console.WriteLine("Impossible");return;
        }
        if (firstCard == secondCard && secondCard == thirdCard && thirdCard == fourthCard || secondCard == thirdCard && thirdCard == fourthCard && fourthCard == fifthCard)
        {
            Console.WriteLine("Four of a Kind");return;
        }
        if (firstCard == secondCard && secondCard == thirdCard && fourthCard == fifthCard || secondCard == thirdCard && thirdCard == fourthCard && fifthCard == firstCard || thirdCard == fourthCard && fourthCard == fifthCard && firstCard == secondCard || fourthCard == fifthCard && fifthCard == firstCard && secondCard == thirdCard || fifthCard == firstCard && firstCard == secondCard && thirdCard == fourthCard)
        {
            Console.WriteLine("Full House"); return;
        }
        if (firstCard == secondCard - 1 && secondCard == thirdCard - 1 && thirdCard == fourthCard - 1 && fourthCard == fifthCard - 1 || secondCard == thirdCard - 1 && thirdCard == fourthCard - 1 && fifthCard == firstCard + 12)
        {
            Console.WriteLine("Straight");return;
        }
        if (firstCard == secondCard && secondCard == thirdCard || secondCard == thirdCard && thirdCard == fourthCard || thirdCard == fourthCard && fourthCard == fifthCard || fourthCard == fifthCard && fifthCard == firstCard || fifthCard == firstCard && firstCard == secondCard)
        {
            Console.WriteLine("Three of a Kind"); return;
        }
        if (firstCard == secondCard && thirdCard == fourthCard || firstCard == secondCard && fourthCard == fifthCard || firstCard == secondCard && thirdCard == fifthCard || secondCard == thirdCard && fourthCard == fifthCard || secondCard == thirdCard && fifthCard == firstCard || secondCard == thirdCard && fourthCard == firstCard || thirdCard == fourthCard && fifthCard == firstCard || thirdCard == fourthCard && firstCard == secondCard)
        {
            Console.WriteLine("Two Pairs"); return;
        }
        if (firstCard == secondCard || secondCard == thirdCard || thirdCard == fourthCard || fourthCard == fifthCard || fifthCard == firstCard)
        {
            Console.WriteLine("One Pair"); return;
        }
        else
        {
            Console.WriteLine("Nothing");
        }
    }
}
