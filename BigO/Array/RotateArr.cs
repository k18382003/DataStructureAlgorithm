using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class RotateArr
    {
        //Resource: https://leetcode.com/problems/rotate-array/
        #region Problem description
        /*
            Given an integer array nums, rotate the array to the right by k steps, 
            where k is non-negative.
        */

        /*
            Example 1:
            Input: nums = [1,2,3,4,5,6,7], k = 3
            Output: [5,6,7,1,2,3,4]
            Explanation:
            rotate 1 steps to the right: [7,1,2,3,4,5,6]
            rotate 2 steps to the right: [6,7,1,2,3,4,5]
            rotate 3 steps to the right: [5,6,7,1,2,3,4]

            Example 2:
            Input: nums = [-1,-100,3,99], k = 2
            Output: [3,99,-1,-100]
            Explanation: 
            rotate 1 steps to the right: [99,-1,-100,3]
            rotate 2 steps to the right: [3,99,-1,-100]
         */

        /*
            Constraints:

            1 <= nums.length <= 105
            -231 <= nums[i] <= 231 - 1
            0 <= k <= 105
         */
        #endregion
        /// <summary>
        /// Approach one: Create an extra array to replace nums' values
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate(int[] nums, int k)
        {
            var numsLength = nums.Length;
            // If k is bigger than nums, it means we'll loop over the nums k/numsLength times 
            // without change any index position. 
            // And then we need to shift the index with the reminder of k % numsLength
            // [1,2,3] k=5 => k = k % 3 => k = 2 
            k %= numsLength;

            var res = new int[numsLength];
            // Copying nums to an new array res
            System.Array.Copy(nums, res, numsLength);

            // Replacing the values from res to nums
            for (int i = numsLength - k, j = 0; j < k; j++, i++)
                nums[j] = res[i];
            for (int i = 0, j = numsLength - (numsLength - k); i < numsLength - k; j++, i++)
                nums[j] = res[i];
        }
        
        /// <summary>
        /// Approach two: Rotate whole, then rotate each half
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate2(int[] nums, int k)
        {
            var numsLength = nums.Length;
            // If k is bigger than nums, it means we'll loop over the nums k/numsLength times 
            // without change any index position. 
            // And then we need to shift the index with the reminder of k % numsLength
            // [1,2,3] k=5 => k = k % 3 => k = 2 
            k %= numsLength;

            // Rotate whole nums
            Reverse(nums, 0, numsLength - 1);
            // Divide nums into 2 parts from index k, and rotate left part
            Reverse(nums, 0, k - 1);
            // Rotate right part
            Reverse(nums, k, numsLength - 1);

        }

        public static void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end++;
            }
        }


        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int value)
            {
                val = value;
                next = null;
            }
        }

        /// <summary>
        /// Approach three: Link list
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public static void Rotate3(int[] nums, int k)
        {
            var numsLength = nums.Length;
            // If k is bigger than nums, it means we'll loop over the nums k/numsLength times 
            // without change any index position. 
            // And then we need to shift the index with the reminder of k % numsLength
            // [1,2,3] k=5 => k = k % 3 => k = 2 
            k %= numsLength;
            if (numsLength == 1 || numsLength == 0)
                return;

            var leftList = CreateNodeList(k,nums, numsLength - k);
            var rightList = CreateNodeList(numsLength - k, nums, 0);
            var cursor = leftList;

            while (cursor.next != null)
                cursor = cursor.next;

            cursor.next = rightList;
            var index = 0;
            while (leftList != null)
            {
                nums[index] = leftList.val;
                leftList = leftList.next;
                index++;
            }

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
        }

        public static ListNode CreateNodeList(int length, int[] nums, int start)
        {
            ListNode head = null;
            ListNode current = null;

            for (int i = 0, j = start; i < length; i++, start++)
            {
                ListNode newNode = new ListNode(nums[start]);

                if (head == null)
                {
                    head = newNode;
                    current = newNode;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }
            }


            return head;
        }

        #region BigO
        /*
            Approach one:
            Time Complexity: O(n)
            The Reverse method performs the array reversal in-place using a two-pointer technique. 
            It iterates from the start and end of the subarray towards the middle, swapping elements until the two pointers meet. 
            This operation takes O(n/2) time, which simplifies to O(n) asymptotically.
            Since the three Reverse operations are performed sequentially, the overall time complexity remains O(n). 

            Space Complexity: O(1)
            The space complexity of the given code is O(1), which means it uses constant space.

            Approach two:
            Time Complexity: O(n)
            I create a new array res of the same size as nums and copies the elements of nums into res using Array.Copy(). 
            This operation has a time complexity of O(n) since it copies all the elements of nums into a new array.
            The subsequent two for loops iterate over the array indices to perform the rotation.
            The first loop copies the elements from the res array starting from index numsLength - k to index k-1 in nums. 
            The second loop copies the remaining elements from the res array starting from index 0 to index numsLength - k - 1 in nums. 
            Both loops iterate k times and have a time complexity of O(k).
            Since k is not necessarily a constant and can be up to the length of the array, the overall time complexity is determined by the maximum of O(n) and O(k).
            However, in the worst case scenario where k is equal to n, the time complexity remains O(n).
            
            Space Complexity: O(n)
            The space complexity of the code is O(n). 
            It creates an additional array res of the same size as nums to store the rotated elements. 
            The space usage increases linearly with the size of the input array. 
            Therefore, the space complexity is O(n).

            Approach Three:
            Time complexity: O(n + (n-k) + k) ===> O(n)
            The time complexity of the `Rotate` method depends on the time complexity of the `CreateNodeList` method, 
            as well as the additional operations performed within the `Rotate` method.
            The `CreateNodeList` method has a time complexity of O(length), where `length` is the value passed as the first argument. 
            It iterates `length` times, performing constant-time operations inside the loop.
            In the `Rotate` method, I first calculate `k %= numsLength`, which is a constant-time operation. 
            The subsequent `if` condition and the assignment of `leftList` and `rightList` have constant-time complexity.
            Next, I have a `while` loop that traverses the linked list created by `CreateNodeList` until `cursor.next` becomes null. 
            Since the length of the linked list is `numsLength - k`, the time complexity of this loop is O(numsLength - k).
            After that, I have another `while` loop that iterates over the linked list until `leftList` becomes null. 
            Since the length of the linked list is `k`, the time complexity of this loop is O(k).
            Overall, the time complexity of the `Rotate` method is determined by the time complexity of the `CreateNodeList` method, 
            which is O(length), as well as the two subsequent loops with complexities of O(numsLength - k) and O(k) respectively.
             
            Space complexity: O(1 + n + n) ===> O(n)
            The space complexity of the given code depends on the space used by the ListNode objects 
            and the auxiliary space used during the execution of the algorithm.

            The ListNode objects themselves have a space complexity of O(1) per node, as they only contain two integer fields (val and next) 
            and don't have any dynamic data structures.

            In the CreateNodeList method, I create a linked list of ListNode objects based on the length parameter. 
            The space used by the linked list depends on the value of length. In the worst case, where length is equal to nums.Length, 
            the space complexity is O(nums.Length). However, the actual space used is proportional to length and varies depending on the input parameters.

            In the Rotate method, I create two linked lists: leftList and rightList. 
            The space complexity of these two linked lists depends on the values of k and numsLength - k. 
            In the worst case, where k is equal to numsLength, the space complexity is O(nums.Length). 
            However, similar to the CreateNodeList method, the actual space used is proportional to the lengths of the lists and varies depending on the input parameters.

            Therefore, the overall space complexity of the given code is primarily determined by the space used by the ListNode objects 
            and the size of the linked lists created, both of which are proportional to the lengths of the lists involved.
         
         */
        #endregion
    }
}
