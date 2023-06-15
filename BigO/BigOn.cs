using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm
{
    // O(n(=)
    internal class BigOn
    {
        List<int> _ListArray = new List<int>();

        public void findThree()
        {
            createList(_ListArray, 100);

            var start = DateTime.Now;

            // It will looping over each item of the List
            // So the runtime is O(n)
            for (int i = 0; i < _ListArray.Count; i++) 
            {
                if (_ListArray[i] == 3)
                    Console.WriteLine("Found!");
            }
            var end = DateTime.Now;

            var runtime = end - start; //Get run time

            Console.WriteLine(runtime.ToString()); //print out the runtime
        }
        
        // Auto generate the list by the given size 
        public List<int> createList(List<int> input, int size)
        {
            Random random = new Random();
            for (int i = 1; i <= size; i++)
                input.Add(random.Next(1, 10));
            return input;
        }

    }
}
