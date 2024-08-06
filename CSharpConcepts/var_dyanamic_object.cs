using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class var_dyanamic_object
    {
        public void varExample()
        {
            var number = 10; // The compiler infers that 'number' is of type int
            var text = "Hello, World!"; // The compiler infers that 'text' is of type string

            Console.WriteLine($"Number: {number}, Type: {number.GetType()}");
            Console.WriteLine($"Text: {text}, Type: {text.GetType()}");

        }

        public void dynamicExample()
        {
            dynamic d = 20;
            Console.WriteLine("Value of d: {0}, Type of d: {1}", d, d.GetType());
            d = "Hello";
            Console.WriteLine("Value of d: {0}, Type of d: {1}", d, d.GetType());
            d = 1.0;
            Console.WriteLine("Value of d: {0}, Type of d: {1}", d, d.GetType());
        }

        public void objectExample()
        {
            object number = 10; // Boxing: int is boxed to an object
            object text = "Hello, World!"; // No boxing needed for reference types

            Console.WriteLine($"Number: {number}, Type: {number.GetType()}");
            Console.WriteLine($"Text: {text}, Type: {text.GetType()}");

            // Unboxing: Casting back to the original type
            int unboxedNumber = (int)number;
            Console.WriteLine($"Unboxed Number: {unboxedNumber}, Type: {unboxedNumber.GetType()}");

        }
    }
}
