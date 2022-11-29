using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[100];

            for (int i = 0; i <= 99; i++)
                array.SetValue(value: i.ToString("00"), index: i);

            Console.Write("{0}", String.Join(", ", array));
            Console.Write("\n");
        }
    }
}
