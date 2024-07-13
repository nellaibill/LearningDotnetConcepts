using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public delegate int Calculation(int a, int b);
    public class DelegateTesting
    {
        
        public int Execute(Func<int, int> calculate, Action<int> print, int input)
        {
            var result = calculate(input);
            print(result);
            return result;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
