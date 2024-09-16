using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotal
{
    public static int[] running_total(int[] input)
    {
        List<int> running_total_list = new List<int>();
        int result = 0;
        foreach (int number in input)
        {
            result += number;
            running_total_list.Add(result);
        }
        return running_total_list.ToArray();
    }
}
