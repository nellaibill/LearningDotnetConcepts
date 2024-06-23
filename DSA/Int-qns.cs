using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
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
            foreach(char c1 in c)
            {
                result += c1;
            }
            Console.WriteLine(result);
            return result;
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
                    if(stack.Count==0)
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count==0;
        }
    }
}
