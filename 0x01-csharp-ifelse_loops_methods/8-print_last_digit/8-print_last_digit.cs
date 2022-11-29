class Number
{
    public static int PrintLastDigit(int number)
    {
        return number >= 0 ? number % 10 : Math.Abs(number % 10);
    }
}
