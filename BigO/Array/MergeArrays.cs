using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class MergeArrays
    {
        // [1, 2, 8, 10]
        // [3, 3, 4, 5, 7, 9]
        // => [1,,,,,,,,10]

        public static int[] MergeArrs(int[] array1, int[] array2)
        {
            // 1. use built-in function
            //int[] mergedArr = new int[array1.Length + array2.Length];
            //mergedArr = array1.Concat(array2).OrderBy(x => x).ToArray();
            //return mergedArr;

            // 2. Use while loop BigO = O(a+b)
            int[] mergedArr = new int[array1.Length + array2.Length];
            var len = (array1.Length + array2.Length) - 1;
            int i = 0;
            int j = 0;
            int k = -1;

            while (k < len)
            {
                k++;
                if ( i >= array1.Length )
                {
                    mergedArr[k] = array2[j];
                    j++;
                    continue;
                }

                if (j >= array2.Length)
                {
                    mergedArr[k] = array1[i];
                    i++;
                    continue;
                }

                if (array1[i] <= array2[j])
                {
                    mergedArr[k] = array1[i];
                    i++;
                }
                else
                {
                    mergedArr[k] = array2[j];
                    j++;
                }
            }

            return mergedArr;

        }
    }
}
