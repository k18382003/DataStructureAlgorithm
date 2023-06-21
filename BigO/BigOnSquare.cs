using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm
{

    internal static class BigOnSquare
    {
        static int[] _Boxes = new int[4] { 1, 2, 3, 4 };
        
        // if we see the nested loop
        // the fisrt instinct for BigO will be O(n^2)
        // This usually comes with poor efficiency, very bad in terms of scalability
        // However, it wiil depend on the size of your input
        // If the input is fixed or always small, this is still a good approach
        // Because it's the most intuitive solution
        public static void printAllPairOfArray()
        {
            int arrlen = _Boxes.Length;
            for (int i = 0; i < arrlen; i++) 
            { 
                for(int j = 0; j < arrlen; j++)
                {
                    Console.WriteLine(_Boxes[i] + " " + _Boxes[j]);
                }
            }
        }

    }
}
