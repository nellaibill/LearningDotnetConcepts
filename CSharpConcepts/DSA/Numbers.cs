using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.DSA
{
    public static class Numbers
    {

        public static int[] circularRotation(int[] input)
        {
            Console.WriteLine("Input " + string.Join(" ",input));
            int inputLength = input.Length;
            int[] result = new int[inputLength];
            
            for(int i = 0; i < inputLength; i++)
            {
                if (i >=2)
                {
                    result[i] = input[i-2];
                }
                else
                {
                    result[i] = input[inputLength - (i + 1)];
                }
                
            }
            return result;
        }
        public static bool AddTwoNumbersWithoutUsingPlusOperator(int a, int b)
        {
         
            int withoutPlusButton = ((b/a)*b -a) ;
            
            return withoutPlusButton == (a + b);
        }

        public static void SwapTwoNumbersWithoutUsingThirdVariable()
        {
             int a = 10;
             int b = 20;

            a = a + b; //30
            b = a - b; //10
            a = a - b; //20
            Console.WriteLine("A : " + a +  " B :  " + b);

        }

        public static bool CheckPalindrome(string word)
        {
            bool result = false;
            if (word.Length == 0) return false;

            string trimmedWord=word.Replace(" ", "").Replace(".", "").ToLower();
            char[] chars = trimmedWord.ToCharArray();
            string reversedWord ="";
            Array.Reverse(chars);
            foreach (char c in chars )
            {
                reversedWord += c;
            }
         
            result = reversedWord.Equals(trimmedWord);
            return result;
        }
    }
}
