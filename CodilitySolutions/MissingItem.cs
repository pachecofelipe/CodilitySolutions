/*
An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.
Your goal is to find that missing element.

Write a function that, given an array A, returns the value of the missing element.
For example, given array A such that:
  A[0] = 2
  A[1] = 3
  A[2] = 1
  A[3] = 5
the function should return 4, as it is the missing element.

Write an efficient algorithm for the following assumptions:
- N is an integer within the range [0..100,000];
- the elements of A are all distinct;
- each element of array A is an integer within the range [1..(N + 1)]
 */

using System.Linq;

namespace CodilitySolutions
{
    public class MissingItem
    {
        public int GetMissingItem(int[] numbersArray)
        {
            if (numbersArray.Length == 0)
            {
                return 1;
            }
            
            var result = Enumerable.Range(1, numbersArray.Length).Except(numbersArray).ToList();
            
            if (result.Count > 0)
            {
                return result[0];
            }

            return numbersArray.Length + 1;
        }
    }
}