using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.OOPS
{
    public static class StaticClass
    {
        public static int IncrementCounter { get; set; }
        static  StaticClass()
        {
            IncrementCounter = 100;
        }

    }
}
