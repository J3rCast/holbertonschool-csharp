using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {

        LinkedListNode<int> myNode = new LinkedListNode<int>(n);
        LinkedListNode<int> node = myLList.First;

        for (int i = 0; i < myLList.Count; i++)
        {
            if (node.Value > myNode.Value)
            {
                node = node.Previous;
                break;
            }

            node = node.Next;
        }

        myLList.AddAfter(node, n);
        return myNode;
    }
}
