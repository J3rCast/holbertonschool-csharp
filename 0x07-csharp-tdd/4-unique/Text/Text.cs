using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    public class Str
    {
		public static int UniqueChar(string s)
		{
			List<char> CharArray = s.ToList();
			List<char> Removed = new List<char>();
			char temp = '\0';

			for (int i = 0; i < s.Length; i++)
			{
				temp = s[i];
				CharArray.RemoveAt(0);

				if (!Removed.Contains(temp) && !CharArray.Contains(temp))
					return i;

				Removed.Add(temp);
			}
			return -1;
		}
    }
}
