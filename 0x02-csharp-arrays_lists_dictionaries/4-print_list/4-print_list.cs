using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
            Console.WriteLine("");

        List<int> list = new List<int>(size);

        for (int i = 0; i < size; i++)
        {
            list.Add(i);
            if (i < size - 1)
                Console.Write("{0} ", i);
            else
                Console.WriteLine("{0}", i);
        }
        return list;
    }
}
