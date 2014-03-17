using System;
using System.Collections.Generic;

class BankAccount
{
    static void Main()
    {
        Console.Title = ("***RAIFAIZEN BANK BULGARIA***");
        string bankName = "RAIFAIZEN BANK BULGARIA";
        Console.WriteLine("{0} \n Enter first Name:",bankName);
        string firstName = (Console.ReadLine());       
        Console.WriteLine("Enter middle Name:");
        string middleName = (Console.ReadLine());
        Console.WriteLine("Enter last Name:");
        string lastName = (Console.ReadLine());
        Console.Clear();

        object fUllName = firstName + " " + middleName + " " + lastName;
        decimal balance = 2.5m;
        string IBAN = "BH 56 AAAA 0000 0123 4567 89";
        string bicCode = "BUINBGSF";
        long firstCreditCard = 4207670054361434;
        long secondCreditCard = 4328810002719770;
        long thirdCreditCard = 5466160175050358;

        Console.WriteLine("{0} \n Personal Information about: \n \n Name: '{1}' \n Balance: '{2}' milions \n IBAN:'{3}' \n BIC code:'{4}' \n \n Credit Card Numbers:\n '{5}' \n '{6}' \n '{7}'",bankName,fUllName,balance,IBAN,bicCode,firstCreditCard,secondCreditCard,thirdCreditCard);


    }
}
