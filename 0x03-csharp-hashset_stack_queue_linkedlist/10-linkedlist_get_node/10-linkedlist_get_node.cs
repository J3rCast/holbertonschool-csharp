using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0)
            return 0;

        LinkedListNode<int> node = myLList.First;

        for (int i = 0; i < myLList.Count; i++)
        {
            if (i == n)
                return node.Value;
            node = node.Next;
        }
        return 0;
    }
}
