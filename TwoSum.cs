using System;
using System.Collections.Generic;

class TwoSum
{
    static int[] Sum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        return [];
    }

    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = Sum(nums, target);
        Console.WriteLine($"{result[0]}, {result[1]}");
    }
}
