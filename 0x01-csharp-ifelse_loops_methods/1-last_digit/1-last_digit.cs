using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int LastDigit = number % 10;

        Console.WriteLine("The last digit of {0} is {1} {2}", number, LastDigit, LastDigit > 5
        ? "and is greater than 5" : (LastDigit == 0 ? "and is 0" 
        : "and is less than 6 and not 0"));
    }
}
