using System;
using System.Collections.Generic;

class Sorting
{
    public static List<int> GetSortedList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        return list;
    }
}
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < list1.Count; i++)
        {
            if (list2.Contains(list1[i]) && result.Contains(list1[i]) == false)
                result.Add(list1[i]);
        }
        return Sorting.GetSortedList(result);
    }
}
