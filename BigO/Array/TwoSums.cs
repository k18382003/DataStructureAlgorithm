using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class TwoSums
    {
        //Resource: https://leetcode.com/problems/two-sum/description/
        #region Problem description
        /*
            Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            You may assume that each input would have exactly one solution, and you may not use the same element twice.
            You can return the answer in any order.
        */

        /*
            Example 1:
            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

            Example 2:
            Input: nums = [3,2,4], target = 6
            Output: [1,2]

            Example 3:
            Input: nums = [3,3], target = 6
            Output: [0,1]
         */

        /*
            Constraints:

            2 <= nums.length <= 104
            -109 <= nums[i] <= 109
            -109 <= target <= 109
            Only one valid answer exists.
         */
        #endregion

        public static int[] funTwoSums(int[] nums, int target)
        {
            // Create a key-pair data structure
            // key: remainder of substraction from target, value: index
            var temp = new Dictionary<int, int>();
            var numsLen = nums.Length;

            // Looping over nums
            for (int i = 0; i < numsLen; i++)
            {
                // if the current value of nums can be found in the temp, it means we find there is a sum that equals to the rarget
                // then we return the index
                if (temp.ContainsKey(nums[i]))
                    return new int[2] { temp[nums[i]], i };
                else
                {
                    // if not, we firstly check if we has the key already
                    // then we add the the remainder to the temp
                    if (!temp.ContainsKey(target - nums[i]))
                        temp.Add(target - nums[i], i);
                }

            }

            // if there aren't any sums from nums that equal to target, return null 
            return null;

        }

        #region BigO
        /*
            Time Complexity: O(n)
            The size of the dictionary can grow up to the number of unique remainders encountered while iterating 
            over the elements of nums. Hence, the time complexity will be O(n).

            Space Complexity: O(n)
            The size of the dictionary can grow up to the number of elements in nums because each element 
            can potentially have a unique remainder key in the dictionary.
            Therefore, the space complexity is directly proportional to the number of elements in nums
            , which is n. Hence, the space complexity is O(n).
         
         */
        #endregion
    }
}
