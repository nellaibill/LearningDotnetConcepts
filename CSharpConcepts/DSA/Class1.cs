using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Class1
    {

        static void SearchElementsFromSortedArray()
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 10 };
            int n, key;
            n = arr.Length;
            key = 10;
            Console.WriteLine(
                      "Index: " + binarySearch(arr, 0, n - 1, key));

        }
        static int binarySearch(int[] arr, int low, int high, int key)
        {

            if (high < low)
            {
                return -1;
            }
            int mid = low + high / 2;
            if (key == arr[mid])
            {
                return mid;
            }
            if (key > arr[mid])
            {
                return binarySearch(arr, mid + 1, high, key);
            }
            return binarySearch(arr, low, mid - 1, key);
        }

        static int findElement(int[] array, int n, int key)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }

        static int deleteElement(int[] array, int n, int key)
        {
            int position = findElement(array, n, key);
            if (position == -1)
            {
                Console.WriteLine("Element not found");
                return n;
            }

            int i;
            for (i = position; i < n - 1; i++)
            {
                array[i] = array[i + 1];
            }
            return n - 1;
        }



        static void DeleteElementsFromTheIntegerArray()
        {
            int[] array = { 10, 50, 30, 40, 20 };
            int n = array.Length;
            int searchKey = 30;
            Console.WriteLine("Before Deletion");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            n = deleteElement(array, n, searchKey);
            Console.WriteLine("After Deletion");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }

        static void FindElementsFromTheIntegerArray()
        {
            int[] array = { 10, 50, 30, 40, 20 };

            int n = array.Length;
            int searchKey = 30;

            int position = findElement(array, n, searchKey);
            if (position == -1)
            {
                Console.WriteLine("Search key not found");
            }
            else
            {
                Console.WriteLine("Search key found at position " + (position + 1));
            }
        }


        //int[] array1 = { 2, 4, 5, 6, 8, 9, 10 };
        //int[] array2 = { 6, 7, 8, 10, 12, 13, 14, 20 };

        ////Output  - 2,4,5,6,7,8,9,10,12, 13, 14, 20

        //for (int i = 0; i < array1.Length; i++)
        //{
        //    if (array1[i] != array2[i])
        //    {

        //    }
        //}
        //FindElementsFromTheIntegerArray();
    }
}
