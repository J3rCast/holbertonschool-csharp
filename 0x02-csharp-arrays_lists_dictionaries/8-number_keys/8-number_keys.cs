﻿using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;
        if (myDict == null)
            return 0;

        foreach (var key in myDict)
            count++;
        
        return count;
    }
}
