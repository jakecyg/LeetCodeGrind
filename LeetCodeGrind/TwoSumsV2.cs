using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeGrind
{
    class TwoSumsV2
    {
        //Given an array of integers numbers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
        //Return the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.length.
        //You may assume that each input would have exactly one solution and you may not use the same element twice.
        public int[] TwoSumV2(int[] numbers, int target)
        {
            Dictionary<int, int> nums = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (nums.ContainsValue(target - numbers[i]))
                    return new int[] { nums.FirstOrDefault(x => x.Value == target - numbers[i]).Key + 1, i + 1 };
                nums.Add(i, numbers[i]);
            }
            throw new Exception();
        }
    }
}
