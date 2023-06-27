using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class MoveZeroes
    {
        //Resource: https://leetcode.com/problems/move-zeroes/description/
        #region Problem description
        /*
            Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

            Note that you must do this in-place without making a copy of the array.
        */

        /*
            Example 1:
            Input: nums = [0,1,0,3,12]
            Output: [1,3,12,0,0]

            Example 2:
            Input: nums = [0]
            Output: [0]
         */

        /*
            Constraints:

            1 <= nums.length <= 104
            -231 <= nums[i] <= 231 - 1
         */
        #endregion

        public static void funMoveZeroes(int[] nums)
        {
            var firstZeroIndex = 0;
            var numsLength = nums.Length;

            if (numsLength == 1)
                return;

            // looping over the input
            for (int i = 0; i < numsLength; i++)
            {
                // if the value is not zero, then we need to swap with the firstZeroindex
                if (nums[i] != 0)
                {
                    var temp = nums[firstZeroIndex];
                    nums[firstZeroIndex] = nums[i];
                    nums[i] = temp;
                    // after swap, we need to push the current firstZeroIndex index to next index
                    firstZeroIndex++;
                }
            }

        }

        #region BigO
        /*
            Time Complexity: O(n)
            I uses a single for loop that iterates through the array once, checking each element.
            Therefore, the time complexity is directly proportional to the number of elements in the array,
            resulting in a linear time complexity of O(n).

            Space Complexity: O(1)
            I do not use any additional data structures or dynamically allocate memory that grows with the size of the input.
            Therefore, the Space Complexity is constant, it's O(1).
         
         */
        #endregion
    }
}
