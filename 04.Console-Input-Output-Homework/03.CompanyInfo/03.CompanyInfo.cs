using System;

class CompanyInfo
{
    static void Main()
    {
        string znak = "***";
        Console.Write("{0,25}INFORMATION ABOUT A COMPANY{0} \n  Enter the name of a company: ",znak);
        string nameCom = Console.ReadLine();

        Console.Write("Enter adress: ");
        string adressCom = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneCom = Console.ReadLine();

        Console.Write("Enter fax number: ");
        string faxCom = Console.ReadLine();

        Console.Write("Enter web site: ");
        string webSiteCom = Console.ReadLine();

        Console.Write("Enter a name of manager: ");
        string managerCom = Console.ReadLine();

        Console.Write("{0,25}INFORMATION ABOUT THE MANAGER{0} \n Enter a first name: ",znak);
        string firstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter a age: ");
        double age = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter phone number: ");
        string phoneMan = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("{1,25}INFORMATION ABOUT {0} COMPANY{1} \n Adress:{2} \n Phone Number:{3} \n Fax Number: {4} \n Web site of the Company:{5} \n Manager's Name:{6} \n {1,25}INFORMATION ABOUT THE MANAGER{1} \n Firts Name:{7} \n Last Name:{8} \n Age:{9} \n Phone Number:{10}.",nameCom,znak,adressCom,phoneCom,faxCom,webSiteCom,managerCom,firstName,lastName,age,phoneMan);

    }
}