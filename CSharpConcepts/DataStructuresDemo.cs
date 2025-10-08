using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public  class DataStructuresDemo
    {
        public void Print()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Elements:"+ string.Join(",", arr));

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");

            int firstElement = (int)arrayList[0];
            string secondElement = (string)arrayList[1];
            Console.WriteLine("ArrayList Elements: {0}, {1}", firstElement, secondElement);

            HashSet<int> hashSet = new HashSet<int> { 1,2,2,3};
            Console.WriteLine("HashSet Elements: " + string.Join(",", hashSet));

            Hashtable hashTable = new Hashtable { { 1, "One" }, { 2,2.2} };
            Console.WriteLine("HashTable Elements: {0}, {1}", hashTable[1], hashTable[2]);


            Dictionary<int, string> dictionary = new Dictionary<int, string> { { 1, "One" }, { 2, "Two" } };
            Console.WriteLine("Dictionary Elements: {0}, {1}", dictionary[1], dictionary[2]);

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("List Elements: " + string.Join(",", list));


        }
    }
}
