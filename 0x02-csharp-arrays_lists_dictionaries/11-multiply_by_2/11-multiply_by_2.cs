using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict == null)
            return myDict;

        Dictionary<string, int> result = new Dictionary<string, int>(myDict);

        foreach (var item in myDict)
        {
            string key = item.Key;
            int value = item.Value;
            result[key] = value * 2;
        }
        return result;
    }
}
