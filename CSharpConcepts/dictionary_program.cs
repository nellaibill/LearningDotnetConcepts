using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class dictionary_program
    {
        // Addition, subtraction, multiplication, and division of two numbers and return their values in a single method
        static Dictionary<string, int> PerformOperations(int a, int b)
        {
            var result = new Dictionary<string, int>()
                {
                    { "sum", a + b },
                    { "difference", a - b },
                    { "product", a * b },
                    { "quotient", a / b }
                };
            return result;
        }

        //sample input and output
        //input: 10, 5

    }

   
}
