using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeGrind
{
    public class TwoSum
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //You can return the answer in any order.

        //Example 1:
        //Input: nums = [2,7,11,15], target = 9
        //Output: [0,1]
        //Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        public int[] TwoSums(int[] nums, int target)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length; i++)
            {
                //if, in the dictionnary- there exists a complement to the current element of nums array- that and this is the pair
                //that adds up to the target. 
                if (numbers.ContainsKey(target - nums[i]))
                    return new int[] {i, numbers[target - nums[i]] };
                numbers.Add(nums[i], i);
            }
            throw new Exception();
        }

    }
}
