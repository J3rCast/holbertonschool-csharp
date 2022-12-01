using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int Count = 0;
        foreach (var item in myLList)
        {
            Count++;
        }
        return Count;
    }
}
