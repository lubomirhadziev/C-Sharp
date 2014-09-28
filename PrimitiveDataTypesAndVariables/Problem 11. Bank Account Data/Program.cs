using System;

class Program
{
    static void Main()
    {
        string firstName = "Lubomir";
        string middleName = "Nedelchev";
        string lastName = "Hadziev";
        decimal balance = 20000.52m;
        string bankName = "Post Bank";
        string iban = "123456789asdfghjkl";
        ushort creditCardNumbers = 123;
        
        Console.WriteLine("{0}/{1}/{2}\nBalance: {3} BGN\nBank:{4}\nIBAN: {5}\nCredit Card: {6}",
            firstName,
            middleName,
            lastName,
            balance,
            bankName,
            iban,
            creditCardNumbers);
    }
}