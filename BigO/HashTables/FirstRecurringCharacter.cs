using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.HashTables
{
    public class FirstRecurringCharacter
    {
        private readonly int[] _Input;
        public FirstRecurringCharacter(int[] input)
        {
            _Input = input;
            FindRecrring(_Input);
        }
        
        private void FindRecrring(int[] _input) 
        {
            
            if (_Input.Length == 0) { Console.WriteLine("Not Found!"); }

            var _hash = new HashSet<int>();

            for (int i = 0; i < _Input.Length; i++) 
            { 
                if (_hash.Contains(_input[i]))
                {
                    Console.WriteLine(_Input[i]);
                    return;
                }

                _hash.Add(_input[i]);
            }

            Console.WriteLine("Not Found!");
        }

    }

    /*
     Time Complexity: O(n)
     The time complexity of the code is O(n), where n is the length of the input array. 
     This is because the code uses a loop to iterate through the input array and performs 
     constant time operations inside the loop (hash table lookups and insertions in the HashSet).

     Space Complexity:
     The space complexity of the code is also O(n), where n is the length of the input array. 
     This is because the code creates a HashSet to store unique elements from the input array. 
     In the worst-case scenario, where all elements in the input array are unique,
     the HashSet will need to store all n elements.
     */
}
