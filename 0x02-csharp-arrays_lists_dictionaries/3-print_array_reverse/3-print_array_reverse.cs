using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("");
            return;
        }

        int i = array.Length;
        for (i = array.Length - 1; i >= 1; i--)
            Console.Write("{0} ", array[i]);

        Console.Write("{0}\n", array[i]);
    }
}
