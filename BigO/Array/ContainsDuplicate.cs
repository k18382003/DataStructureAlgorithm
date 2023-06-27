using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class ContainsDuplicate
    {
        //Resource: https://leetcode.com/problems/two-sum/description/
        #region Problem description
        /*
            Given an integer array nums, 
            return true if any value appears at least twice in the array, 
            and return false if every element is distinct.
        */

        /*
            Example 1:
            Input: nums = [1,2,3,1]
            Output: true

            Example 2:
            Input: nums = [1,2,3,4]
            Output: false
        
            Example 3:
            Input: nums = [1,1,1,3,3,4,3,2,4,2]
            Output: true
         */

        /*
            Constraints:

            1 <= nums.length <= 105
            -109 <= nums[i] <= 109
         */
        #endregion
        public static bool funContainsDuplicate(int[] nums)
        {
            var numsLength = nums.Length;
            var tempHash = new Dictionary<int, int>();

            if (numsLength == 1)
                return false;

            for (int i = 0; i < numsLength; i++)
            {
                if (tempHash.ContainsKey(nums[i]))
                    return true;
                else
                {
                    tempHash.Add(nums[i], i);
                }
            }

            /*
                Or we can use HashSet
                var hashSet = new HashSet<int>(nums.Length);
                for (int i = 0; i < nums.Length; i++) {
                    if (hashSet.Contains(nums[i])) return true;
                    hashSet.Add(nums[i]);
                }

                return false;
             */

            return false;

        }

        #region BigO
        /*
            Time Complexity: O(n)
            The size of the dictionary can grow up to the number of unique remainders encountered while iterating 
            over the elements of nums. Hence, the time complexity will be O(n).

            Space Complexity: O(n)
            The size of the dictionary can grow up to the number of elements in the worst senario (e.g. can't find duplicate).
            Therefore, the space complexity is directly proportional to the number of elements in nums
            , which is n. Hence, the space complexity is O(n).
         
         */
        #endregion
    }
}
