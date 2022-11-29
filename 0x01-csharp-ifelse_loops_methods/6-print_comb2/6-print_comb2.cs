using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 1;
            for (i = 0; i < 10 ; i++)
            {
                while (j < 10)
                {
                    if (i == 8 && j == 9)
                        Console.Write("{0}{1}\n", i, j);
                    else if (i != j)
                        Console.Write("{0}{1}, ", i, j);
                    j++;
                }
                j = i + 1;
            }
        }
    }
}
