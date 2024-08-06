using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpConcepts
{
    static class CollectionTest
    {
        public static void RemoveDuplicates(int[] test)
        {
            HashSet<int> list = new HashSet<int>();
            foreach (int testItem in test)
            {
                list.Add(testItem);
            }
            Console.WriteLine(list);
        }
        public static void MaximumInteger(int[] test)
        {

            int temp = 0;
            foreach (int testItem in test)
            {
                temp = testItem > temp ? testItem : temp;
            }
            Console.WriteLine(temp);
        }

        public static void ReverseString(string item)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char testItem in item)
            {
                stack.Push(testItem);
            }
            var test1 = stack.ToArray();
            Console.WriteLine(test1);
        }

        public static void MergeArrays(int[] array1, int[] array2)
        {
            Console.WriteLine(string.Join(",", array1.Concat(array2).OrderBy(x => x).ToArray()));
        }

        public static void IntersectArrays(int[] array1, int[] array2)
        {
            HashSet<int> hs1 = new HashSet<int>();
            foreach (int testItem in array1)
            {
                if (array2.Contains(testItem))
                {
                    hs1.Add(testItem);
                }
            }
            Console.WriteLine(string.Join(",", array1.Intersect(array2).ToArray()));
            Console.WriteLine(string.Join(",", hs1.ToArray()));
        }

        public static void LongestSubstring(string test)
        {

        }
    }
}
