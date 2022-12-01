using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());
        
        aQueue.Enqueue(newItem);

        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        List<string> Copy = new List<string>(aQueue);
        if (aQueue.Contains(search))
            for (int i = 0; i < Copy.Count; i++)
            {
                aQueue.Dequeue();
                if (Copy[i] == search)
                    break;
            }
        return aQueue;
    }
}
