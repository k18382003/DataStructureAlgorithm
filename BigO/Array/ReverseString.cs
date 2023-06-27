using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Array
{
    internal class ReverseString
    {
        public static string Reverse(string input)
        {
            // Check input
            if (input == null || input.GetType() != typeof(string)) return "Invalid input";

            var length = input.Length - 1;

            if (length == 0) return input;

            // Create a new string and append the input backwordly
            var res = new StringBuilder();
            for (int i = length; i >= 0; i--)
                res.Append(input[i]);

            return res.ToString();
        }

        // Use build-in function, make code cleaner
        public static string Reverse2(string input) => string.Concat(input.ToArray().Reverse());
    }
}
