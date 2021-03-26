using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilitySolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMissingItem();
            RunBinaryGap();
            RunArrayRotation();
        }

        private static void RunArrayRotation()
        {
            const int shift = 7; 
            var array = new int[] {1, 2, 3, 4, 5};
            var result = new CyclicRotation().RotateArray(array, shift);
            Console.WriteLine($"Shifting array [{string.Join(",", array.Select(x=>x.ToString()).ToArray())}] {shift} times " +
                              $"results to array [{string.Join(",", result.Select(x=>x.ToString()).ToArray())}]");
        }

        private static void RunMissingItem()
        {
            var missingItem = new MissingItem();
            var arrays = new List<int[]>
            {
                new int[] {1, 5, 4, 7, 3, 2},
                new int[] {-1, 1, 2},
                new int[] {0, 2, 2, 1, 4}
            };

            foreach (var array in arrays)
            {
                var result = missingItem.GetMissingItem(array);
                Console.WriteLine($"The missing item in array {string.Join(",", array.Select(x=>x.ToString()).ToArray())} is {result}");
            }
        }

        private static void RunBinaryGap()
        {
            var binaryGap = new BinaryGap();
            foreach (var number in Enumerable.Range(100, 100))
            {
                Console.WriteLine($"The longest binary gap of {number} is {BinaryGap.GetLongestBinaryGap(number)}");
            }
        }
    }
}