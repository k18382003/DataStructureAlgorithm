using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O(n):");
            BigOn.findThree();
            Console.WriteLine("--------------------");
            Console.WriteLine("O(n^2):");
            BigOnSquare.printAllPairOfArray();
            Console.WriteLine("--------------------");            


            Console.Read();
        }
    }
}
