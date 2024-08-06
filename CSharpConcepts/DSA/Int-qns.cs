using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.DSA
{
    class Int_qns
    {
        public void question1()
        {
            List<int> lstnumbers = Enumerable.Range(0, 20).ToList();

            foreach (int i in lstnumbers)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var test = lstnumbers.Where(x => x % 2 == 0).ToList().Take(3);
            Console.WriteLine("linq " + String.Join(" ", test));

        }
        public void question2()
        {
            bool isValid = isValidBraces("(())");
            if (isValid)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("InValid");
            }
        }
        public string question3()
        {
            string name = "Saleem";
            char[] c = name.ToCharArray();
            string result = "";
            Array.Reverse(c);
            foreach (char c1 in c)
            {
                result += c1;
            }
            Console.WriteLine(result);
            return result;
        }

        public int question4()
        {
            int result = 0;
            var list = Enumerable.Range(0, 6).ToList();
            result = list.Where(x => x % 2 == 0).Sum(x => x);
            Console.WriteLine("Sum of Integer Numbers: " + result);
            return result;
        }
        public void question5()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("A Value:" + a);
            Console.WriteLine("B Value:" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Swapped A Value:" + a);
            Console.WriteLine("Swapped B Value:" + b);
        }

        public void question6()
        {
            int[,] matrix = {
                              { 1,1,2},
                              { 2,4,3},
                              { 5,6,1}
                            };
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine("Diagnol of matrix " + sum);
        }

        public void question7()
        {
            int[] result = { 1, 0, 1, 1, 0, 1, 1 };

            var linq_result = result.Select(x => x.Equals(1) ? x + 2 : x).ToList();
            Console.WriteLine("Chage Value with Linq: " + String.Join(" ", linq_result));
        }
        static bool isValidBraces(string value)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in value)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        public  void question8()
        {
            string word = "aabcccccaaa";
            char previousCharacter = word[0];
            //would become  "a2b1c5a3.
            List<char> result = new List<char>();
            foreach(char c in word)
            {
                if (previousCharacter == c)
                {
                    result.Add(c);
                }
                else
                {
                    Console.Write(previousCharacter+":" + result.Count);
                    result.Clear();
                }
                
                previousCharacter = c;


            }
            Console.Write(previousCharacter + ":" + result.Count);
        }
    }

}
