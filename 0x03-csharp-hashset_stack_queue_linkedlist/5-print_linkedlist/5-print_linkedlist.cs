using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> result = new LinkedList<int>();

        if (size < 0)
            return result;


        for (int i = 0; i < size; i++)
        {
            result.AddLast(i);
            Console.WriteLine(i);
        }
        return result;
    }
}
