using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = -1;
        string maxScore = "";

        if (myList.Count == 0 || myList == null)
            return "None";

        foreach (var item in myList)
        {
            if (item.Value > max)
            {
                max = item.Value;
                maxScore = item.Key;
            }
        }

        return maxScore;
    }
}
