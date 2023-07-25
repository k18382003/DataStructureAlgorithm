using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure_Algorithm.Array;
using DataStructure_Algorithm.HashTables;

namespace DataStructure_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("O(n):");
            //BigOn.findThree();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("O(n^2):");
            //BigOnSquare.printAllPairOfArray();
            //Console.WriteLine("--------------------");            

            //MyArray myArray = new MyArray();
            //myArray.Add("hi");
            //myArray.Add("Summer");
            //myArray.Add("teng");
            //myArray.Insert(4, "!");

            //for (int i = 0; i < myArray._length; i++)
            //{
            //    Console.WriteLine(myArray.get(i));
            //}

            //TwoSums.funTwoSums(new int[] { 1, 2, 5, -3, 4, -1 }, 9);
            //ContainsDuplicate.funContainsDuplicate(new int[] { -1, -100, 3, 99 });
            //MergeArrays.MergeArrs(new int[] { 1, 2, 3, 4 }, new int[] { 8, 9, -2, 12 });
            //MoveZeroes.funMoveZeroes(new int[] { 0, 1, 2, 0, 3 });
            //ReverseString.Reverse("Summer Teng");
            //ReverseString.Reverse2("Alice Chen");
            //RotateArr.Rotate(new int[] { -1, -100, 3, 99 }, 2);

            //CombinationOfPhoneNumber.LetterCombinations("23");

            //var myHashTable = new ImplementingHashTable(50);
            //myHashTable.Set("AB", 10000);
            //myHashTable.Set("CB", 55);

            //var res = myHashTable.Get("AB");
            //Console.WriteLine(res);
            //res = myHashTable.Get("CB");
            //Console.WriteLine(res);
            //res = myHashTable.Get("DD");
            //Console.WriteLine(res);

            new FirstRecurringCharacter(new int[] { 2, 1, 3, 2 });

            Console.Read();
        }
    }
}
