using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[100];

            for (int i = 0; i <= 99; i++)
                array.SetValue(value: i, index: i);

            Console.WriteLine("{0}", String.Join(", ", array));
        }
    }
}
