using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        LinkedListNode<int> node = myLList.First;

        for (int i = 0; i < myLList.Count; i++)
        {
            if (node.Value == value)
                return i;
            node = node.Next;
        }
        return -1;
    }
}
