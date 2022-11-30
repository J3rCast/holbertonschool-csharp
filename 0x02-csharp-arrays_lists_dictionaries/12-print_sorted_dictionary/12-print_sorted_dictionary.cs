using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = from entry in myDict orderby entry.Key ascending select entry;

        foreach (var item in sortedDict)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}
