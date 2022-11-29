using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int LastDigit = number % 10;
        string SubString = "";

        if (LastDigit > 5)
            SubString = "and is greater than 5";
        else if (LastDigit == 0)
            SubString = "and is 0";
        else if (LastDigit < 6)
            SubString = "and is less than 6 and not 0";

        Console.WriteLine("The last digit of {0} is {1} {2}", number, LastDigit, SubString);
    }
}
