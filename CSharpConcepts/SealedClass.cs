using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    sealed class SealedClass
    {
        public SealedClass()
        {
            Console.WriteLine("SealedClass-Constructor");
        }
        public void PrintMethod()
        {
            Console.WriteLine("Test");
        }
    }

}
